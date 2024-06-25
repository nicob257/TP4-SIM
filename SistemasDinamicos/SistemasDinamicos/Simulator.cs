using RandomVarGenerator;
using System.Collections.Generic;
using System;

public class Simulator
{
    private UniformGenerator uniformGenerator = new UniformGenerator();
    private StateRow rowActual;
    private Random rndClase = new Random();
    private double pCompra;
    private double pEntrega;
    private int liTiempoLlegCli;
    private int lsTiempoLlegCli;
    private int liTiempoAtCompra;
    private int lsTiempoAtCompra;
    private int liTiempoRepReloj;
    private int lsTiempoRepReloj;
    private int liProfInsp;
    private int lsProfInsp;
    private int tmpOrden;

    private List<Tupla> listaRk = new List<Tupla>();

    public void InicializarProbabilidades(double pCompra, double pEntrega, int liTiempoLlegCli, int lsTiempoLlegCli, int liTiempoAtCompra,
        int lsTiempoAtCompra, int liTiempoRepReloj, int lsTiempoRepReloj, int tmpOrden, int liProfInsp, int lsProfInsp)
    {
        this.pCompra = pCompra;
        this.pEntrega = pEntrega;
        this.liTiempoLlegCli = liTiempoLlegCli;
        this.lsTiempoLlegCli = lsTiempoLlegCli;
        this.liTiempoAtCompra = liTiempoAtCompra;
        this.lsTiempoAtCompra = lsTiempoAtCompra;
        this.liTiempoRepReloj = liTiempoRepReloj;
        this.lsTiempoRepReloj = lsTiempoRepReloj;
        this.tmpOrden = tmpOrden;
        this.liProfInsp = liProfInsp;
        this.lsProfInsp = lsProfInsp;
    }

    private void InicializarSistema()
    {
        rowActual = new StateRow();
        rowActual.Minutos = 0;
        rowActual.ColaRetir = 3;
        rowActual.EstadoAtencion = "Libre";
        rowActual.EstadoRepar = "Libre";
        rowActual.Evento = "Inicio";
        GenerarLlegada();
    }

    public List<object> Simular(int tiempoSimulacion, int numIteraciones, int i, int j)
    {
        InicializarSistema();
        int iteracion = 0;
        List<object> vectores = new List<object>();
        if (iteracion >= j && iteracion < j + i)
        {
            vectores.Add(AgregarRow());
        }


        while (rowActual.Minutos < tiempoSimulacion && iteracion < numIteraciones)
        {

            Evento eventoActual = rowActual.EncontrarMenorTiempo();

            rowActual.TiAtAyudante = (rowActual.EstadoAtencion == "Atendiendo") ? rowActual.TiAtAyudante + (eventoActual.Tiempo - rowActual.Minutos) : rowActual.TiAtAyudante;
            rowActual.TiAtRelojero = (rowActual.EstadoRepar == "Reparando") ? rowActual.TiAtRelojero + (eventoActual.Tiempo - rowActual.Minutos) : rowActual.TiAtRelojero;

            rowActual.Minutos = eventoActual.Tiempo;

            if(rowActual.Minutos < tiempoSimulacion)
            {
                switch (eventoActual.Nombre)
                {
                    case "Llegada":
                        ManejarLlegada();
                        break;
                    case "Fin Atención":
                        ManejarFinAtencion();
                        break;
                    case "Fin Reparación":
                        ManejarFinReparacion();
                        break;
                    case "Fin Orden":
                        ManejarFinOrdenar();
                        break;
                }

                if (iteracion >= j && iteracion < j + i)
                {
                    vectores.Add(AgregarRow());
                }

            }
            iteracion++;

        }

        if (rowActual.Minutos > tiempoSimulacion)
        {
            rowActual.Evento = "Fin Simulación";
            rowActual.Minutos = tiempoSimulacion;
            rowActual.RndTipo = rowActual.RndTiempo = rowActual.TiempoAt = rowActual.RndLlegada = rowActual.TmpLlegada = 0;
            rowActual.MinFinOrden = rowActual.RndReparacion = rowActual.TmpReparacion = 0;
            vectores.Add(AgregarRow());
        }

        return vectores;
    }

    private void GenerarLlegada()
    {
        rowActual.RndLlegada = rndClase.NextDouble();
        rowActual.TmpLlegada = GenerarTiempoLlegadaCliente(rowActual.RndLlegada);
        rowActual.MinLlegada = rowActual.Minutos + rowActual.TmpLlegada;
    }

    private void ManejarLlegada()
    {
        if (rowActual.EstadoAtencion == "Libre")
        {
            GenerarTipoCliente();
            rowActual.EstadoAtencion = "Atendiendo";
        }
        else
        {
            rowActual.ColaAtencion++;
            rowActual.RndTipo = rowActual.RndTiempo = rowActual.TiempoAt = 0;
        }
        rowActual.RndReparacion = rowActual.TmpReparacion = 0;

        rowActual.Evento = "Llegada";
        GenerarLlegada();
    }

    private void GenerarTipoCliente()
    {
        rowActual.RndTiempo = 0;
        rowActual.RndTipo = rndClase.NextDouble();

        if (rowActual.RndTipo <= pCompra)
        {
            rowActual.Tipo = "Compra";
            rowActual.RndTiempo = rndClase.NextDouble();
            rowActual.TiempoAt = GenerarTiempoAtencionCompra(rowActual.RndTiempo);
        }
        else if (rowActual.RndTipo <= (pCompra + pEntrega))
        {
            rowActual.Tipo = "Entrega";
            rowActual.RndProfundidadInspeccion = rndClase.NextDouble();
            rowActual.ProfundidadInspeccion = (int)Math.Truncate(uniformGenerator.Generate(liProfInsp, lsProfInsp + 1, rowActual.RndProfundidadInspeccion));
            rowActual.TiempoAt = ObtenerTiempoAtencionRK(rowActual.ProfundidadInspeccion);
        }
        else
        {
            rowActual.Tipo = "Retiro";
            rowActual.RndProfundidadInspeccion = rndClase.NextDouble();
            rowActual.ProfundidadInspeccion = (int)Math.Truncate(uniformGenerator.Generate(liProfInsp, lsProfInsp + 1, rowActual.RndProfundidadInspeccion));
            rowActual.TiempoAt = ObtenerTiempoAtencionRK(rowActual.ProfundidadInspeccion);
        }
        rowActual.MinFinAtencion = rowActual.Minutos + rowActual.TiempoAt;
    }

    private void ManejarFinAtencion()
    {
        rowActual.Evento = "Fin Atención";
        rowActual.RndLlegada = rowActual.TmpLlegada = 0;
        if (rowActual.Tipo == "Entrega")
        {
            if (rowActual.EstadoRepar == "Libre")
            {
                rowActual.EstadoRepar = "Reparando";
                GenerarReparacion();
            }
            else
            {
                rowActual.ColaRepar += 1;
            }
        }
        else if (rowActual.Tipo == "Retiro")
        {
            if (rowActual.ColaRetir > 0)
            {
                rowActual.ColaRetir -= 1;
                rowActual.CantReti += 1;
            }
            else
            {
                rowActual.RetFrac += 1;
                rowActual.CantReti += 1;
            }
        }

        if (rowActual.ColaAtencion > 0)
        {
            GenerarTipoCliente();
            rowActual.ColaAtencion -= 1;
        }
        else
        {
            rowActual.EstadoAtencion = "Libre";
            rowActual.MinFinAtencion = 0;
            rowActual.Tipo = "";
            rowActual.RndTipo = rowActual.RndProfundidadInspeccion = rowActual.ProfundidadInspeccion = 0;
            rowActual.TiempoAt = rowActual.RndTiempo = 0;
        }
    }

    private void GenerarReparacion()
    {
        rowActual.RndReparacion = rndClase.NextDouble();
        rowActual.TmpReparacion = GenerarTiempoReparacionReloj(rowActual.RndReparacion);
        rowActual.MinFinRepar = rowActual.Minutos + rowActual.TmpReparacion;
    }

    private void ManejarFinReparacion()
    {
        rowActual.RndTipo = rowActual.RndTiempo = rowActual.TiempoAt = rowActual.RndLlegada = rowActual.TmpLlegada = 0;
        rowActual.MinFinRepar = 0;
        rowActual.Evento = "Fin Reparación";
        rowActual.ColaRetir += 1;
        rowActual.EstadoRepar = "Ordenando";
        GenerarOrdenar();
    }

    private void GenerarOrdenar()
    {
        rowActual.MinFinOrden = rowActual.Minutos + tmpOrden;
    }

    private void ManejarFinOrdenar()
    {
        rowActual.RndTipo = rowActual.RndTiempo = rowActual.TiempoAt = rowActual.RndLlegada = rowActual.TmpLlegada = 0;
        rowActual.MinFinOrden = 0;
        rowActual.Evento = "Fin Ordenar";
        if (rowActual.ColaRepar > 0)
        {
            rowActual.ColaRepar -= 1;
            GenerarReparacion();
            rowActual.EstadoRepar = "Reparando";
        }
        else
        {
            rowActual.EstadoRepar = "Libre";
        }
    }

    private double GenerarTiempoLlegadaCliente(double rnd)
    {
        return uniformGenerator.Generate(liTiempoLlegCli, lsTiempoLlegCli, rnd);
    }

    private double GenerarTiempoAtencionCompra(double rnd)
    {
        return uniformGenerator.Generate(liTiempoAtCompra, lsTiempoAtCompra, rnd);
    }

    private double GenerarTiempoReparacionReloj(double rnd)
    {
        return uniformGenerator.Generate(liTiempoRepReloj, lsTiempoRepReloj, rnd);
    }

    private object AgregarRow()
    {
        var rowMostrar = rowActual.Clone();
        return rowMostrar;
    }

    public double ObtenerPNoReparado()
    {
        if (rowActual.CantReti != 0)
        {
            return Math.Round(((double)rowActual.RetFrac / (double)rowActual.CantReti), 4);
        }
        else return 0;
    }

    public double ObtenerPorcOcupacionAyudante()
    {
        return Math.Round((rowActual.TiAtAyudante / rowActual.Minutos) * 100, 2);
    }

    public double ObtenerPorcOcupacionRelojero()
    {
        return Math.Round((rowActual.TiAtRelojero / rowActual.Minutos) * 100, 2);
    }

    public List<RkRow> CalcularRK(int v1, double v2, int v3, double h, int lsInsp)
    {
        List<RkRow> lista = new List<RkRow>();
        double insp = 0;
        double t = 0;
        double k1 = h * (v1 * Math.Pow((t + v2), 2) + v3);
        double k2 = h * (v1 * Math.Pow((t + h / 2 + v2), 2) + v3);
        double k3 = h * (v1 * Math.Pow((t + h / 2 + v2), 2) + v3);
        double k4 = h * (v1 * Math.Pow((t + h + v2), 2) + v3);
        double sigInsp = insp + (1.0 / 6 * (k1 + 2 * k2 + 2 * k3 + k4));
        listaRk.Add(new Tupla(t, insp));
        lista.Add(new RkRow
        {
            t = t,
            I = insp,
            K1 = Math.Round(k1, 4),
            K2 = Math.Round(k2, 4),
            K3 = Math.Round(k3, 4),
            K4 = Math.Round(k4, 4),
            Isig = Math.Round(sigInsp, 1),
        });
        while (insp < lsInsp)
        {
            t += h;
            insp = sigInsp;
            k1 = h * (v1 * Math.Pow((t + v2), 2) + v3);
            k2 = h * (v1 * Math.Pow((t + h / 2 + v2), 2) + v3);
            k3 = h * (v1 * Math.Pow((t + h / 2 + v2), 2) + v3);
            k4 = h * (v1 * Math.Pow((t + h + v2), 2) + v3);
            sigInsp = insp + (1.0 / 6 * (k1 + 2 * k2 + 2 * k3 + k4));
            lista.Add(new RkRow
            {
                t = Math.Round(t, 1),
                I = Math.Round(insp, 1),
                K1 = Math.Round(k1, 4),
                K2 = Math.Round(k2, 4),
                K3 = Math.Round(k3, 4),
                K4 = Math.Round(k4, 4),
                Isig = Math.Round(sigInsp, 1),
            });
            listaRk.Add(new Tupla(t, insp));
        }
        return lista;
    }

    private double ObtenerTiempoAtencionRK(int profundidadInspeccion)
    {
        for (int i = 0; i < listaRk.Count; i++)
        {
            if (listaRk[i].Segundo >= profundidadInspeccion)
            {
                return listaRk[i].Primero;
            }
        }
        return 0;
    }
}
