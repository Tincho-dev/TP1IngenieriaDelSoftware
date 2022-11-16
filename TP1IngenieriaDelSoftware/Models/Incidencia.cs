using TP1IngenieriaDelSoftware.Model;

namespace TP1IngenieriaDelSoftware.Models
{
    public class Incidencia
    {
        public DateTime Hora { get; set; }
        public Defecto? Defecto { get; set; }
        public PieSentido Pie { get; set; }
        public int Cantidad; // 1 o -1

        public Incidencia(DateTime hora, Defecto defecto, PieSentido pie, int cantidad)
        {
            Hora = hora;
            Defecto = defecto;
            Pie = pie;
            Cantidad = cantidad;
        }

        public Incidencia(DateTime hora, PieSentido pie, int cantidad) 
        {
            Hora = hora;
            Pie = pie;
            Cantidad = cantidad;
        }
    }
}
