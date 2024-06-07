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
    public double TiempoLlegada { get; set; }
    public double MinutosLlegada { get; set; }
    public int ColaAtencion { get; set; }
    public double RndTipo { get; set; }
    public string Tipo { get; set; }
    public double RndTiempo { get; set; }
    public double Tiempo { get; set; }
    public double MinutosFinAtencion { get; set; }
    public int ColaReparacion { get; set; }
    public double RndReparacion { get; set; }
    public double TiempoReparacion { get; set; }
    public double MinutosFinReparacion { get; set; }
    public string EstadoAtencion { get; set; }
    public string EstadoReparacion { get; set; }
}

