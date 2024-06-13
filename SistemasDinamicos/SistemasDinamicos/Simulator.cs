using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    private StateRow rowAnterior;
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
    private double tiempoAtencionRelojero;
    private double tiempoAtencionAyudante;
    private double tiempoFinSimulacion;
    private double tiempoAtencion;
    private Cliente ultimoCliente;
    private string ultimoEstadoAtencion;
    
    public void InicializarSistema()
    {
        reparando = false;
        cantRetirosNoExitosos = 0;
        cantRetiros = 0;
        rndTiempoAtencion = 0;
        rndTiempoLlegada = 0;
        rndTiempoReparacion = 0;
        rndTipoAtencion = 0;
        minutosFinAtencion = 0;
        eventos.Clear();
        estados.Clear();
        colaRelojes.Clear();
        colaClientes.Clear();
        tiempoAtencionAyudante = 0;
        tiempoAtencionRelojero = 0;
        for (int i = 0; i < 3; i++)
        {
            colaRelojes.Enqueue(new Reloj { Estado = "Listo para retirar" });
        }
        Evento inicioEvento = new Evento { Nombre = "Inicio", Tiempo = 0 };
        eventos.Add(inicioEvento);


    }

    public List<StateRow> Simular(int tiempoSimulacion, int numIteraciones, int i, int j, 
        double pCompra, double pEntrega, double pRetiro, 
        int liTiempoLlegCli, int lsTiempoLlegCli, int liTiempoAtCompra, int lsTiempoAtCompra, int liTiempoRepReloj, int lsTiempoRepReloj)
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
                    ManejarInicio(relojSimulacion, liTiempoLlegCli, lsTiempoLlegCli);
                    break;
                case "Llegada Cliente":
                    ManejarLlegadaCliente(relojSimulacion, pCompra, pEntrega, pRetiro, liTiempoLlegCli, lsTiempoLlegCli, liTiempoAtCompra, lsTiempoAtCompra);
                    inicio = false;
                    break;
                case "Fin Atención Cliente":
                   
                        tiempoAtencionAyudante += ultimoCliente.TiempoAtencion;
                    
                    ManejarFinAtencionCliente(relojSimulacion, liTiempoRepReloj, lsTiempoRepReloj, liTiempoAtCompra, lsTiempoAtCompra);
                    inicio = false;
                    break;
                case "Fin Reparación Reloj":
                    tiempoAtencionRelojero += GenerarTiempoReparacionReloj(liTiempoRepReloj, lsTiempoRepReloj, rndTiempoReparacion);
                    ManejarFinReparacionReloj(relojSimulacion);
                    inicio = false;
                    break;
                case "Fin Ordenar LT":
                    ManejarFinOrdenar(relojSimulacion, liTiempoRepReloj, lsTiempoRepReloj);
                    inicio = false;
                    break;
            }

            if (iteracion >= j && iteracion < j + i)
            {
                estados.Add(CrearStateRow(relojSimulacion, eventoActual,inicio,
                    liTiempoLlegCli, lsTiempoLlegCli, liTiempoAtCompra, lsTiempoAtCompra, liTiempoRepReloj, lsTiempoRepReloj));
            }

            iteracion++;
        }
        tiempoFinSimulacion = relojSimulacion;
        if (minutosFinAtencion != 0)
        {
            if (colaClientes.Count != 0) {
                tiempoAtencionAyudante += (colaClientes.Peek().TiempoAtencion - (minutosFinAtencion - tiempoFinSimulacion));
            }
            
        }
        if (minutosFinReparacion != 0)
        {
            tiempoAtencionRelojero += (GenerarTiempoReparacionReloj(liTiempoRepReloj, lsTiempoRepReloj, rndTiempoReparacion) - (minutosFinReparacion - tiempoFinSimulacion));
        }
       
        

        estados.Add(CrearStateRow(relojSimulacion, new Evento { Nombre = "Fin Simulación", Tiempo = relojSimulacion },inicio,
            liTiempoLlegCli, lsTiempoLlegCli, liTiempoAtCompra, lsTiempoAtCompra, liTiempoRepReloj, lsTiempoRepReloj));
        //MostrarEstados();s
        

        Console.WriteLine("Cola clientes: " + colaClientes.Count + "|" + "Cola relojes: " + colaRelojes.Count);
       
        return estados;
    }
    private void ManejarInicio(double tiempo, int liLlegada, int lsLlegada)
    {
        rndTiempoLlegada = rndClase.NextDouble();
        double tiempoLlegada = GenerarTiempoLlegadaCliente(liLlegada, lsLlegada, rndTiempoLlegada);
        minutosLlegada = tiempo + tiempoLlegada;
        
        
        eventos.Add(new Evento { Nombre = "Llegada Cliente", Tiempo = minutosLlegada });
    }

    private void ManejarLlegadaCliente(double tiempo, double pCompra, double pEntrega, double pRetiro, 
        int liLlegada, int lsLlegada, int liAtCompra, int lsAtCompra)
    {
        Cliente cliente = new Cliente();
        ultimoCliente = cliente;
        
        rndTipoAtencion = rndClase.NextDouble();

        if (rndTipoAtencion <= pCompra)
        {
            Console.WriteLine("Estado: " + (rndTipoAtencion <= pCompra) + "P(Compra): " + pCompra.ToString());
            cliente.Tipo = "Compra";
            
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
        Console.WriteLine(colaClientes.Count + " fgsdgadg " + minutosFinAtencion + " sdfgdsg " + tiempo);
        if (colaClientes.Count == 0 && minutosFinAtencion < tiempo)
        {
            ultimoEstadoAtencion = ultimoCliente.Tipo;
            if (cliente.Tipo == "Compra")
            {
                rndTiempoAtencion = rndClase.NextDouble();
                cliente.TiempoAtencion = GenerarTiempoAtencionCompra(liAtCompra, lsAtCompra, rndTiempoAtencion);
                
            }
            tiempoAtencion = cliente.TiempoAtencion;
            minutosFinAtencion = tiempo + tiempoAtencion;
            eventos.Add(new Evento { Nombre = "Fin Atención Cliente", Tiempo = minutosFinAtencion });
        }
        else
        {
            Console.WriteLine("AAAAAAAAAAAAAAAAAAA");
            colaClientes.Enqueue(cliente);
        }
        rndTiempoLlegada = rndClase.NextDouble();
        
        double tiempoLlegada = GenerarTiempoLlegadaCliente(liLlegada, lsLlegada, rndTiempoLlegada);
        minutosLlegada = tiempo + tiempoLlegada;
        eventos.Add(new Evento { Nombre = "Llegada Cliente", Tiempo = minutosLlegada });
    }

    private void ManejarFinAtencionCliente(double tiempo, int liRepReloj, int lsRepReloj, int liAt, int lsAt)
    {
        Console.WriteLine(colaClientes.Count);
        if (ultimoCliente.Tipo == "Entrega")
        {
            int relojesEnCola = 0;
            foreach (Reloj reloj in colaRelojes)
            {
                if (reloj.Estado == "En espera de reparación")
                {
                    relojesEnCola += 1;
                }
            }
            if (relojesEnCola == 0 && estadoRepar == "Libre")
            {
                estadoRepar = "Reparando";
                colaRelojes.Enqueue(new Reloj { Estado = "En espera de reparación" });
                rndTiempoReparacion = rndClase.NextDouble();
                double tiempoReparacion = GenerarTiempoReparacionReloj(liRepReloj, lsRepReloj, rndTiempoReparacion);
                minutosFinReparacion = tiempo + tiempoReparacion;
                eventos.Add(new Evento { Nombre = "Fin Reparación Reloj", Tiempo = minutosFinReparacion });
                reparando = true;
            }
            else
            {
                colaRelojes.Enqueue(new Reloj { Estado = "En espera de reparación" });
            }
        }
        else if (ultimoCliente.Tipo == "Retiro")
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
        if (colaClientes.Count > 0)
        {
            Cliente cliente = colaClientes.Dequeue();
            ultimoCliente = cliente;
            ultimoEstadoAtencion = cliente.Tipo;
            if (cliente.Tipo == "Compra")
            {
                rndTiempoAtencion = rndClase.NextDouble();
                cliente.TiempoAtencion = GenerarTiempoAtencionCompra(liAt, lsAt, rndTiempoAtencion);
                tiempoAtencion = cliente.TiempoAtencion;
                
            }
            else
            {
                cliente.TiempoAtencion = 3;
            }
            minutosFinAtencion += cliente.TiempoAtencion;
            eventos.Add(new Evento { Nombre = "Fin Atención Cliente", Tiempo = minutosFinAtencion });
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

    private void ManejarFinOrdenar(double tiempo, int liRepReloj, int lsRepReloj)
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
                    eventos.Add(new Evento { Nombre = "Fin Reparación Reloj", Tiempo = tiempo + GenerarTiempoReparacionReloj(liRepReloj, lsRepReloj, rndTiempoReparacion) });
                    break;
                }
            }
        }
    }

    private double GenerarTiempoLlegadaCliente(int li, int ls, double rnd)
    {
        return uniformGenerator.Generate(li, ls, rnd);
    }

    private double GenerarTiempoAtencionCompra(int li, int ls, double rnd)
    {
        return uniformGenerator.Generate(li, ls, rnd);
    }

    private double GenerarTiempoReparacionReloj(int li, int ls, double rnd)
    {
        return uniformGenerator.Generate(li, ls, rnd);
    }

    private StateRow CrearStateRow(double tiempo, Evento evento, bool inicio,
        int liTiempoLlegCli, int lsTiempoLlegCli, int liTiempoAtCompra, int lsTiempoAtCompra, int liTiempoRepReloj, int lsTiempoRepReloj
       )
    {
        bool generarRnd;
        int retirar = 0;
        int reparar = 0;
        rndTiempoAtencion = Math.Truncate(rndTiempoAtencion * 10000) / 10000;


        if ((rowAnterior != null) && (rowAnterior.RndTiempo == rndTiempoAtencion))
        {
            rowAnterior.RndTiempo = Math.Truncate(rowAnterior.RndTiempo * 10000) / 10000;
            generarRnd = false;
            
        } else
        {
            generarRnd = true; 
        }
       
        foreach (Reloj reloj in colaRelojes)
        {
            if (reloj.Estado == "Listo para retirar")
            {
                retirar += 1;
            }
            else if (reloj.Estado == "En espera de reparación") {
                reparar += 1;
            }

        }
            var row = new StateRow
        {
            Evento = evento.Nombre,
            Minutos = Math.Truncate(tiempo*10000)/10000,
            RndLlegada = (evento.Nombre == "Llegada Cliente" || evento.Nombre == "Inicio") ? (Math.Truncate(rndTiempoLlegada*10000)/10000) : 0,
            TmpLlegada = (evento.Nombre == "Llegada Cliente" || evento.Nombre == "Inicio")? Math.Truncate((GenerarTiempoLlegadaCliente(liTiempoLlegCli, lsTiempoLlegCli, rndTiempoLlegada)) * 10000) / 10000 : 0,
            MinLlegada = (evento.Nombre == "Llegada Cliente" || evento.Nombre == "Inicio")? Math.Truncate(minutosLlegada * 10000) / 10000 : 0,
            ColaAtencion = colaClientes.Count,
            RndTipo = evento.Nombre == "Llegada Cliente" ? Math.Truncate(rndTipoAtencion*10000)/10000 : 0,
            Tipo = (evento.Nombre == "Llegada Cliente") ? ultimoCliente.Tipo : "",
            RndTiempo = (generarRnd) ? rndTiempoAtencion : 0,
            TiempoAt = ((evento.Nombre == "Llegada Cliente" || evento.Nombre == "Fin Atención Cliente")) ? Math.Truncate(ultimoCliente.TiempoAtencion*10000)/ 10000 : 0,
            MinFinAtencion = Math.Truncate(((evento.Nombre == "Llegada Cliente" || evento.Nombre == "Fin Atención Cliente" || evento.Nombre == "Fin Ordenar LT") ? minutosFinAtencion : 0)*10000) / 10000,
            RelojARepar = reparar,
            RelojARetir = retirar,
            RndReparacion = reparando ? Math.Truncate(rndTiempoReparacion * 10000) / 10000 : 0,
            TmpReparacion = reparando ? Math.Truncate(GenerarTiempoReparacionReloj(liTiempoRepReloj, lsTiempoRepReloj, rndTiempoReparacion) * 10000) / 10000 : 0,
            MinFinRepar = reparando ? Math.Truncate((minutosFinReparacion)*10000)/10000 : 0,
            EstadoAtencion = minutosFinAtencion > tiempo ? "Atendiendo" : "Libre",
            EstadoRepar = estadoRepar,
            CantReti = cantRetiros,
            RetFrac = cantRetirosNoExitosos,
            TiAtAyudante = Math.Round(tiempoAtencionAyudante, 2),
            TiAtRelojero = Math.Round(tiempoAtencionRelojero, 2),
            };
        reparando = false;
        if (generarRnd)
        {
            rowAnterior = row;
        }
        return row;
    }

    //private void MostrarEstados()
    //{
    //    foreach (var row in estados)
    //    {
    //        Console.WriteLine($"Evento: {row.Evento}, Minutos: {row.Minutos}, RND Llegada: {row.RndLlegada}, Tiempo Llegada: {row.TmpLlegada}, Minutos Llegada: {row.MinLlegada}, " +
    //                          $"Cola Atencion: {row.ColaAtencion}, RND Tipo: {row.RndTipo}, Tipo: {row.Tipo}, RND Tiempo: {row.RndTiempo}, Tiempo: {row.Tiempo}, Minutos Fin Atencion: {row.MinFinAtencion}, " +
    //                          $"Cola Reparacion: {row.RelojARepar}, RND Reparacion: {row.RndReparacion}, Tiempo Reparacion: {row.TmpReparacion}, Minutos Fin Reparacion: {row.MinFinRepar}, " +
    //                          $"Estado Atencion: {row.EstadoAtencion}, Estado Reparacion: {row.EstadoRepar}");
    //        // Completa el resto de la información que deseas mostrar
    //    }
    //}


    public double ObtenerPNoReparado()
    {
        if (cantRetiros != 0)
        {
            return Math.Round(((double)cantRetirosNoExitosos / (double)cantRetiros), 4);
        }
            
        else return 0;
    }
    public double ObtenerPorcOcupacionAyudante()
    {
        return (Math.Round(((tiempoAtencionAyudante / tiempoFinSimulacion) * 100), 2));
    }

    public double ObtenerPorcOcupacionRelojero()
    {
        return (Math.Round(((tiempoAtencionRelojero / tiempoFinSimulacion) * 100), 2));
    }
}


