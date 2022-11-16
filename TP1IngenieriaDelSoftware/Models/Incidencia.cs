using TP1IngenieriaDelSoftware.Model;

namespace TP1IngenieriaDelSoftware.Models
{
    public class Incidencia
    {
        public DateTime Hora { get; set; }
        public Defecto Defecto { get; set; }
        public PieSentido Pie { get; set; }

        public RegistroDefectos(DateTime hora, Defecto defecto, PieSentido pie)
        {
            Hora = hora;
            Defecto = defecto;
            Pie = pie;
        }
    }
}
