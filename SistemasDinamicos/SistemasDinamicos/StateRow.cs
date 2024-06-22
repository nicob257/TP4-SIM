using SistemasDinamicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        return MemberwiseClone();
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

