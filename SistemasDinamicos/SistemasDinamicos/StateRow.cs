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
    public int ColaAtencion { get; set; }
    public double RndTipo { get; set; }
    public string Tipo { get; set; }
    public double RndTiempo { get; set; }
    public double Tiempo { get; set; }
    public double MinFinAtencion { get; set; }
    public int ColaRetiro { get; set; }
    public int ColaReparacion { get; set; }
    public double RndReparacion { get; set; }
    public double TmpReparacion { get; set; }
    public double MinFinRepar { get; set; }
    public string EstadoAtencion { get; set; }
    public string EstadoRepar { get; set; }


}

