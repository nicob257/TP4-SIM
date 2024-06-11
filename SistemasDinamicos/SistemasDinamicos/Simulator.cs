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
    private int cantRetirosNoExitosos;
    private int cantRetiros;
    private bool inicio;
    private string estadoRepar = "Libre";
    private bool reparando;
    Reloj[] arrayColas;
    private bool noHay;
    public void InicializarSistema()
    {
        reparando = false;
        cantRetirosNoExitosos = 0;
        cantRetiros = 0;
        rndTiempoAtencion = 0;
        rndTiempoLlegada = 0;
        rndTiempoReparacion = 0;
        rndTipoAtencion = 0;
        eventos.Clear();
        estados.Clear();
        colaRelojes.Clear();
        for (int i = 0; i < 3; i++)
        {
            colaRelojes.Enqueue(new Reloj { Estado = "Listo para retirar" });
        }

        eventos.Add(new Evento { Nombre = "Inicio", Tiempo = 0 });

    }

    public List<StateRow> Simular(int tiempoSimulacion, int numIteraciones, int i, int j, double pCompra, double pEntrega, double pRetiro)
    {
        double relojSimulacion = 0;
        int iteracion = 0;
        inicio = true;

        while (relojSimulacion < tiempoSimulacion && iteracion < numIteraciones)
        {
            eventos.Sort((e1, e2) => e1.Tiempo.CompareTo(e2.Tiempo));
            Evento eventoActual = eventos[0];
            eventos.RemoveAt(0);
            relojSimulacion = eventoActual.Tiempo;
            

            switch (eventoActual.Nombre)
            {
                case "Inicio":
                    ManejarInicio(relojSimulacion);
                    eventoActual.Nombre = "Llegada Cliente";
                    break;
                case "Llegada Cliente":
                    ManejarLlegadaCliente(relojSimulacion, pCompra, pEntrega, pRetiro);
                    inicio = false;
                    break;
                case "Fin Atención Cliente":
                    ManejarFinAtencionCliente(relojSimulacion);
                    inicio = false;
                    break;
                case "Fin Reparación Reloj":
                    ManejarFinReparacionReloj(relojSimulacion);
                    inicio = false;
                    break;
                case "Fin Ordenar LT":
                    ManejarFinOrdenar(relojSimulacion);
                    inicio = false;
                    break;
            }

            if (iteracion >= j && iteracion < j + i)
            {
                estados.Add(CrearStateRow(relojSimulacion, eventoActual,inicio));
            }

            iteracion++;
        }

        estados.Add(CrearStateRow(relojSimulacion, new Evento { Nombre = "Fin Simulación", Tiempo = relojSimulacion },inicio));
        MostrarEstados();
        Console.WriteLine("Cola clientes: " + colaClientes.Count + "|" + "Cola relojes: " + colaRelojes.Count);
        //Console.WriteLine("Cantidad retiros: " + cantRetiros + "Cantidad retiros no exitosos: " + cantRetirosNoExitosos + "P: " + (cantRetirosNoExitosos/cantRetiros));
        //Console.WriteLine((cantRetirosNoExitosos/cantRetiros));
        return estados;
    }
    private void ManejarInicio(double tiempo)
    {
        Cliente cliente = new Cliente();

        rndTiempoLlegada = rndClase.NextDouble();
        double tiempoLlegada = uniformGenerator.Generate(13, 17, rndTiempoLlegada);
        minutosLlegada = tiempo + tiempoLlegada;
        
        eventos.Add(new Evento { Nombre = "Llegada Cliente", Tiempo = minutosLlegada });
    }

        private void ManejarLlegadaCliente(double tiempo, double pCompra, double pEntrega, double pRetiro)
    {
        Cliente cliente = new Cliente();
        rndTipoAtencion = rndClase.NextDouble();

        if (rndTipoAtencion <= pCompra)
        {
            Console.WriteLine("Estado: " + (rndTipoAtencion <= pCompra) + "P(Compra): " + pCompra.ToString());
            cliente.Tipo = "Compra";
            rndTiempoAtencion = rndClase.NextDouble();
            cliente.TiempoAtencion = GenerarTiempoAtencionCompra(rndTiempoAtencion);
        }
        else if (rndTipoAtencion <= (pCompra + pEntrega))
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
            if (cliente.Tipo == "Entrega")
            {
                estadoRepar = "Reparando";
                colaRelojes.Enqueue(new Reloj { Estado = "En espera de reparación" });
                rndTiempoReparacion = rndClase.NextDouble();
                double tiempoReparacion = GenerarTiempoReparacionReloj(rndTiempoReparacion);
                minutosFinReparacion = tiempo + tiempoReparacion;
                eventos.Add(new Evento { Nombre = "Fin Reparación Reloj", Tiempo = minutosFinReparacion });
                reparando = true;
            }
            else if (cliente.Tipo == "Retiro")
            {
                if (colaRelojes.Count > 0)
                {
                    noHay = true;
                    arrayColas = colaRelojes.ToArray();
                    for (int i = 0; i < arrayColas.Length; i++)
                    {
                        Reloj reloj = arrayColas[i];
                        if (reloj.Estado == "Listo para retirar")
                        {
                            cantRetiros++;
                            arrayColas = arrayColas.Where((val, idx) => idx != i).ToArray();
                            colaRelojes = new Queue<Reloj>(arrayColas);
                            noHay = false;
                            break;
                        }
                    }
                    if (noHay)
                    {
                        cantRetirosNoExitosos++;
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
        foreach (Reloj reloj in colaRelojes)
        {
            if (reloj.Estado == "En espera de reparación")
            {
                reloj.Estado = "Listo para retirar";
                break;
            }
        }
        eventos.Add(new Evento { Nombre = "Fin Ordenar LT", Tiempo = tiempo + 5 });
        estadoRepar = "Ordenando";
    }

    private void ManejarFinOrdenar(double tiempo)
    {
        estadoRepar = "Libre";
        if (colaRelojes.Count() > 0)
        {
            foreach (Reloj reloj in colaRelojes)
            {
                if (reloj.Estado == "En espera de reparación")
                {
                    estadoRepar = "Reparando";
                    reloj.Estado = "Reparando";
                    reparando = true;
                    rndTiempoReparacion = rndClase.NextDouble();
                    eventos.Add(new Evento { Nombre = "Fin Reparación Reloj", Tiempo = tiempo + GenerarTiempoReparacionReloj(rndTiempoReparacion) });
                    break;
                }
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

    private StateRow CrearStateRow(double tiempo, Evento evento, bool inicio)
    {
        int retirar = 0;
        int reparar = 0;
        foreach (Reloj reloj in colaRelojes)
        {
            if (reloj.Estado == "Listo para retirar")
            {
                retirar += 1;
            }
            else {
                reparar += 1;
            }

        }
            var row = new StateRow
        {
            Evento = inicio ? "Inicio" : evento.Nombre,
            Minutos = Math.Truncate(tiempo*10000)/10000,
            RndLlegada = evento.Nombre == "Llegada Cliente" ? (Math.Truncate(rndTiempoLlegada*10000)/10000) : 0,
            TmpLlegada = evento.Nombre == "Llegada Cliente" ? Math.Truncate(GenerarTiempoLlegadaCliente(rndTiempoLlegada)*10000)/10000 : 0,
            MinLlegada = evento.Nombre == "Llegada Cliente" ? Math.Truncate((tiempo + GenerarTiempoLlegadaCliente(rndTiempoLlegada))*10000)/10000 : 0,
            ColaAtencion = colaClientes.Count,
            RndTipo = evento.Nombre == "Llegada Cliente" ? Math.Truncate(rndTipoAtencion*10000)/10000 : 0,
            Tipo = colaClientes.Count > 0 && evento.Nombre == "Llegada Cliente" ? colaClientes.Peek().Tipo : "",
            RndTiempo = evento.Nombre == "Llegada Cliente" ? Math.Truncate(rndTiempoAtencion * 10000) / 10000 : 0,
            Tiempo = colaClientes.Count > 0 ? Math.Truncate(colaClientes.Peek().TiempoAtencion*10000)/ 10000 : 0,
            MinFinAtencion = Math.Truncate((colaClientes.Count > 0 ? minutosFinAtencion : 0)*10000) / 10000,
            RelojARepar = reparar,
            RelojARetir = retirar,
            RndReparacion = reparando ? Math.Truncate(rndTiempoReparacion * 10000) / 10000 : 0,
            TmpReparacion = reparando ? Math.Truncate(GenerarTiempoReparacionReloj(rndTiempoReparacion) * 10000) / 10000 : 0,
            MinFinRepar = reparando ? Math.Truncate((tiempo + GenerarTiempoReparacionReloj(rndTiempoReparacion))*10000)/10000 : 0,
            EstadoAtencion = colaClientes.Count > 0 ? "Atendiendo" : "Libre",
            EstadoRepar = estadoRepar,
            CantReti = cantRetiros,
            RetFrac = cantRetirosNoExitosos,
            };
        reparando = false;
        return row;
    }

    private void MostrarEstados()
    {
        foreach (var row in estados)
        {
            Console.WriteLine($"Evento: {row.Evento}, Minutos: {row.Minutos}, RND Llegada: {row.RndLlegada}, Tiempo Llegada: {row.TmpLlegada}, Minutos Llegada: {row.MinLlegada}, " +
                              $"Cola Atencion: {row.ColaAtencion}, RND Tipo: {row.RndTipo}, Tipo: {row.Tipo}, RND Tiempo: {row.RndTiempo}, Tiempo: {row.Tiempo}, Minutos Fin Atencion: {row.MinFinAtencion}, " +
                              $"Cola Reparacion: {row.RelojARepar}, RND Reparacion: {row.RndReparacion}, Tiempo Reparacion: {row.TmpReparacion}, Minutos Fin Reparacion: {row.MinFinRepar}, " +
                              $"Estado Atencion: {row.EstadoAtencion}, Estado Reparacion: {row.EstadoRepar}");
            // Completa el resto de la información que deseas mostrar
        }
    }
}


