using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using RandomVarGenerator;

public class Simulator
{
    private UniformGenerator uniformGenerator = new UniformGenerator();
    private Queue<Cliente> colaClientes = new Queue<Cliente>();
    private Queue<Reloj> colaRelojes = new Queue<Reloj>();
    private List<Evento> eventos = new List<Evento>();
    private List<StateRow> estados = new List<StateRow>();
    private Random rndClase = new Random();
    private double rndTiempoLlegada;
    private double rndTipoAtencion;
    private double rndTiempoAtencion;
    private double rndTiempoReparacion;
    private double minutosLlegada;
    private double minutosFinAtencion;
    private double minutosFinReparacion;
    public void InicializarSistema()
    {
        for (int i = 0; i < 3; i++)
        {
            colaRelojes.Enqueue(new Reloj { Estado = "Listo para retirar" });
        }

        eventos.Add(new Evento { Nombre = "Llegada Cliente", Tiempo = 15 });
    }

    public void Simular(int tiempoSimulacion, int numIteraciones, int i, int j)
    {
        double relojSimulacion = 0;
        int iteracion = 0;

        while (relojSimulacion < tiempoSimulacion && iteracion < numIteraciones)
        {
            eventos.Sort((e1, e2) => e1.Tiempo.CompareTo(e2.Tiempo));
            Evento eventoActual = eventos[0];
            eventos.RemoveAt(0);
            relojSimulacion = eventoActual.Tiempo;

            switch (eventoActual.Nombre)
            {
                case "Llegada Cliente":
                    ManejarLlegadaCliente(relojSimulacion);
                    break;
                case "Fin Atención Cliente":
                    ManejarFinAtencionCliente(relojSimulacion);
                    break;
                case "Fin Reparación Reloj":
                    ManejarFinReparacionReloj(relojSimulacion);
                    break;
            }

            if (iteracion >= j && iteracion < j + i)
            {
                estados.Add(CrearStateRow(relojSimulacion, eventoActual));
            }

            iteracion++;
        }

        estados.Add(CrearStateRow(relojSimulacion, new Evento { Nombre = "Fin Simulación", Tiempo = relojSimulacion }));
        MostrarEstados();
        Console.WriteLine("Cola clientes: " + colaClientes.Count + "|" + "Cola relojes: " + colaRelojes.Count);
    }

    private void ManejarLlegadaCliente(double tiempo)
    {
        Cliente cliente = new Cliente();
        rndTipoAtencion = rndClase.NextDouble();
        
        if (rndTipoAtencion <= 0.45)
        {
            cliente.Tipo = "Compra";
            rndTiempoAtencion = rndClase.NextDouble();
            cliente.TiempoAtencion = GenerarTiempoAtencionCompra(rndTiempoAtencion);
        }
        else if (rndTipoAtencion <= 0.70)
        {
            cliente.Tipo = "Entrega";
            cliente.TiempoAtencion = 3;
        }
        else
        {
            cliente.Tipo = "Retiro";
            cliente.TiempoAtencion = 3;
        }
        minutosFinAtencion = tiempo + cliente.TiempoAtencion;
        eventos.Add(new Evento { Nombre = "Fin Atención Cliente", Tiempo = minutosFinAtencion });
        colaClientes.Enqueue(cliente);
        rndTiempoLlegada = rndClase.NextDouble();
        double tiempoLlegada = uniformGenerator.Generate(13, 17, rndTiempoLlegada);
        minutosLlegada = tiempo + tiempoLlegada;
        eventos.Add(new Evento { Nombre = "Llegada Cliente", Tiempo = minutosLlegada });
    }

    private void ManejarFinAtencionCliente(double tiempo)
    {
        if (colaClientes.Count > 0)
        {
            Cliente cliente = colaClientes.Dequeue();
            List<Reloj> listaRelojes = colaRelojes.ToList();
            if (cliente.Tipo == "Entrega")
            {

                if (!listaRelojes.Contains(new Reloj { Estado = "En espera de reparación"})) {
                    rndTiempoReparacion = rndClase.NextDouble();
                    double tiempoReparacion = GenerarTiempoReparacionReloj(rndTiempoReparacion);
                    minutosFinReparacion = tiempo + tiempoReparacion;
                    eventos.Add(new Evento { Nombre = "Fin Reparación Reloj", Tiempo = minutosFinReparacion });
                }
                colaRelojes.Enqueue(new Reloj { Estado = "En espera de reparación" });
 
               
            }
            else if (cliente.Tipo == "Retiro")
            {
                // ACA HAY QUE CAMBIAR ALGO SEGURO, puse el if para que no crashee si no hay relojes nomas xd
                if (colaRelojes.Count > 1)
                {
                    Reloj reloj = colaRelojes.Peek();
                    if (reloj.Estado == "Listo para retirar")
                    {
                        colaRelojes.Dequeue();
                    }
                }
                
            }
        }

        if (colaClientes.Count > 0)
        {
            Cliente siguienteCliente = colaClientes.Peek();
            eventos.Add(new Evento { Nombre = "Fin Atención Cliente", Tiempo = tiempo + siguienteCliente.TiempoAtencion });
        }

    }

    private void ManejarFinReparacionReloj(double tiempo)
    {
        if (colaRelojes.Count > 0)
        {
            Reloj reloj = colaRelojes.Dequeue();
            reloj.Estado = "Listo para retirar";
            colaRelojes.Enqueue(reloj);
            if (colaRelojes.Count > 0)
            {
                rndTiempoReparacion = rndClase.NextDouble();
                eventos.Add(new Evento { Nombre = "Fin Reparación Reloj", Tiempo = tiempo + GenerarTiempoReparacionReloj(rndTiempoReparacion) + 5 });
            }
        }
    }

    private double GenerarTiempoLlegadaCliente(double rnd)
    {
        return uniformGenerator.Generate(13, 17, rnd);
    }

    private double GenerarTiempoAtencionCompra(double rnd)
    {
        return uniformGenerator.Generate(6, 10, rnd);
    }

    private double GenerarTiempoReparacionReloj(double rnd)
    {
        return uniformGenerator.Generate(18, 22, rnd);
    }

    private StateRow CrearStateRow(double tiempo, Evento evento)
    {
        var row = new StateRow
        {
            Evento = evento.Nombre,
            Minutos = tiempo,
            RndLlegada = evento.Nombre == "Llegada Cliente" ? rndTiempoLlegada : 0,
            TiempoLlegada = evento.Nombre == "Llegada Cliente" ? GenerarTiempoLlegadaCliente(rndTiempoLlegada) : 0,
            MinutosLlegada = evento.Nombre == "Llegada Cliente" ? tiempo + GenerarTiempoLlegadaCliente(rndTiempoLlegada) : 0,
            ColaAtencion = colaClientes.Count,
            RndTipo = evento.Nombre == "Llegada Cliente" ? rndTipoAtencion : 0,
            Tipo = colaClientes.Count > 0 ? colaClientes.Peek().Tipo : "",
            RndTiempo = evento.Nombre == "Llegada Cliente" ? rndTiempoAtencion : 0,
            Tiempo = colaClientes.Count > 0 ? colaClientes.Peek().TiempoAtencion : 0,
            MinutosFinAtencion = tiempo + (colaClientes.Count > 0 ? colaClientes.Peek().TiempoAtencion : 0),
            ColaReparacion = colaRelojes.Count,
            RndReparacion = evento.Nombre == "Fin Reparación Reloj" ? rndTiempoReparacion : 0,
            TiempoReparacion = evento.Nombre == "Fin Reparación Reloj" ? GenerarTiempoReparacionReloj(rndTiempoReparacion) : 0,
            MinutosFinReparacion = evento.Nombre == "Fin Reparación Reloj" ? tiempo + GenerarTiempoReparacionReloj(rndTiempoReparacion) + 5 : 0,
            EstadoAtencion = colaClientes.Count > 0 ? "Atendiendo" : "Libre",
            EstadoReparacion = colaRelojes.Count > 0 ? "Reparando" : "Libre"
        };

        return row;
    }

    private void MostrarEstados()
    {
        foreach (var row in estados)
        {
            Console.WriteLine($"Evento: {row.Evento}, Minutos: {row.Minutos}, RND Llegada: {row.RndLlegada}, Tiempo Llegada: {row.TiempoLlegada}, Minutos Llegada: {row.MinutosLlegada}, " +
                              $"Cola Atencion: {row.ColaAtencion}, RND Tipo: {row.RndTipo}, Tipo: {row.Tipo}, RND Tiempo: {row.RndTiempo}, Tiempo: {row.Tiempo}, Minutos Fin Atencion: {row.MinutosFinAtencion}, " +
                              $"Cola Reparacion: {row.ColaReparacion}, RND Reparacion: {row.RndReparacion}, Tiempo Reparacion: {row.TiempoReparacion}, Minutos Fin Reparacion: {row.MinutosFinReparacion}, " +
                              $"Estado Atencion: {row.EstadoAtencion}, Estado Reparacion: {row.EstadoReparacion}");
            // Completa el resto de la información que deseas mostrar
        }
    }

    public List<StateRow> Estados => estados;  // Exponer la lista de estados 
}


