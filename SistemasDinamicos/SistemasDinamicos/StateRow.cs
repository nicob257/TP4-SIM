using SistemasDinamicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class StateRow
{
    public string Evento { get; set; }
    public double Minutos { get; set; }
    public double RndLlegada { get; set; }
    public double TmpLlegada { get; set; }
    public double MinLlegada { get; set; }
    public double RndTipo { get; set; }
    public string Tipo { get; set; }
    public double RndTiempo { get; set; }
    public double RndProfundidadInspeccion { get; set; }
    public int ProfundidadInspeccion { get; set; }
    public double TiempoAt { get; set; }
    public double MinFinAtencion { get; set; }
    public int ColaAtencion { get; set; }
    public int ColaRetir { get; set; }
    public int ColaRepar { get; set; }
    public double RndReparacion { get; set; }
    public double TmpReparacion { get; set; }
    public double MinFinRepar { get; set; }
    public double MinFinOrden { get; set; }
    public string EstadoAtencion { get; set; }
    public string EstadoRepar { get; set; }
    public int CantReti { get; set; }
    public int RetFrac { get; set; }
    public double TiAtAyudante { get; set; }
    public double TiAtRelojero { get; set; }
    public List<Reloj> Relojes { get; set; }
    public object Clone()
    {
        StateRow rowAClonar = this;
        rowAClonar.Minutos = (rowAClonar.Minutos != 0 ? Math.Round(rowAClonar.Minutos, 4) : rowAClonar.Minutos);
        rowAClonar.RndLlegada = (rowAClonar.RndLlegada != 0 ? Math.Round(rowAClonar.RndLlegada, 4) : rowAClonar.RndLlegada);
        rowAClonar.TmpLlegada = (rowAClonar.TmpLlegada != 0 ? Math.Round(rowAClonar.TmpLlegada, 4) : rowAClonar.TmpLlegada);
        rowAClonar.MinLlegada = (rowAClonar.MinLlegada != 0 ? Math.Round(rowAClonar.MinLlegada, 4) : rowAClonar.MinLlegada);
        rowAClonar.RndTiempo = (rowAClonar.RndTiempo != 0 ? Math.Round(rowAClonar.RndTiempo, 4) : rowAClonar.RndTiempo);
        rowAClonar.RndTipo = (rowAClonar.RndTipo != 0 ? Math.Round(rowAClonar.RndTipo, 4) : rowAClonar.RndTipo);
        rowAClonar.RndProfundidadInspeccion = (rowAClonar.RndProfundidadInspeccion != 0 ? Math.Round(rowAClonar.RndProfundidadInspeccion, 4) : rowAClonar.RndProfundidadInspeccion);
        rowAClonar.TiempoAt = (rowAClonar.TiempoAt != 0 ? Math.Round(rowAClonar.TiempoAt, 4) : rowAClonar.TiempoAt);
        rowAClonar.MinFinAtencion = (rowAClonar.MinFinAtencion != 0 ? Math.Round(rowAClonar.MinFinAtencion, 4) : rowAClonar.MinFinAtencion);
        rowAClonar.RndReparacion = (rowAClonar.RndReparacion != 0 ? Math.Round(rowAClonar.RndReparacion, 4) : rowAClonar.RndReparacion);
        rowAClonar.TmpReparacion = (rowAClonar.TmpReparacion != 0 ? Math.Round(rowAClonar.TmpReparacion, 4) : rowAClonar.TmpReparacion);
        rowAClonar.MinFinRepar = (rowAClonar.MinFinRepar != 0 ? Math.Round(rowAClonar.MinFinRepar, 4) : rowAClonar.MinFinRepar);
        rowAClonar.MinFinOrden = (rowAClonar.MinFinOrden != 0 ? Math.Round(rowAClonar.MinFinOrden, 4) : rowAClonar.MinFinOrden);
        rowAClonar.TiAtAyudante = (rowAClonar.TiAtAyudante != 0 ? Math.Round(rowAClonar.TiAtAyudante, 4) : rowAClonar.TiAtAyudante);
        rowAClonar.TiAtRelojero = (rowAClonar.TiAtRelojero != 0 ? Math.Round(rowAClonar.TiAtRelojero, 4) : rowAClonar.TiAtRelojero);


        return rowAClonar.MemberwiseClone();
    }
    public Evento EncontrarMenorTiempo()
    {
        var eventos = new List<Evento>
        {
            new Evento { Nombre = "Llegada", Tiempo = MinLlegada },
            new Evento { Nombre = "Fin Atención", Tiempo = MinFinAtencion },
            new Evento { Nombre = "Fin Reparación", Tiempo = MinFinRepar },
            new Evento { Nombre = "Fin Orden", Tiempo = MinFinOrden }
        };

        Evento menorEvento = eventos[0];
        foreach (var evento in eventos)
        {
            if (evento.Tiempo < menorEvento.Tiempo && evento.Tiempo != 0)
            {
                menorEvento = evento;
            }
        }

        return menorEvento;
    }
}

