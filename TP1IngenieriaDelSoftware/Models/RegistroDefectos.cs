using API_TFI.Model;
using NodaTime;

namespace TP1IngenieriaDelSoftware.Models
{
    public class RegistroDefectos
    {
        public LocalTime Hora { get; set; }
        public Defecto Defecto { get; set; }
        public PieSentido Pie { get; set; }

        public RegistroDefectos(LocalTime hora, Defecto defecto, PieSentido pie)
        {
            Hora = hora;
            Defecto = defecto;
            Pie = pie;
        }
    }
}
