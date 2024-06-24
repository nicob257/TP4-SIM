using System;
using System.Collections.Generic;
using RandomVarGenerator;

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
    private int tmpOrden;

    public void InicializarProbabilidades(double pCompra, double pEntrega, int liTiempoLlegCli, int lsTiempoLlegCli, int liTiempoAtCompra, 
        int lsTiempoAtCompra, int liTiempoRepReloj, int lsTiempoRepReloj, int tmpOrden)
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
       
        while (rowActual.Minutos < tiempoSimulacion && iteracion < numIteraciones)
        {
            if (iteracion >= j && iteracion < j + i)
            {
                vectores.Add(AgregarRow());
            }
            Evento eventoActual = rowActual.EncontrarMenorTiempo();
            rowActual.Minutos = eventoActual.Tiempo;
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

            iteracion++;
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
            rowActual.TiempoAt = 3;
        }
        else
        {
            rowActual.Tipo = "Retiro";
            rowActual.TiempoAt = 3;
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
                rowActual.ColaRepar += 1 ;
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
            rowActual.RndTipo = 0;
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
        return 1.0;
    }

    public double ObtenerPorcOcupacionRelojero()
    {
        return 1.0;
    }
}


