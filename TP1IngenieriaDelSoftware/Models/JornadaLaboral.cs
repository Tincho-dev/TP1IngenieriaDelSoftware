using NodaTime;
using TP1IngenieriaDelSoftware.Models;

namespace TP1IngenieriaDelSoftware.Model
{
    public class JornadaLaboral
    {
 
        public DateTime FechaI { get; set; }
        public LocalTime FechaF { get; set; }// cambair todos o por LocalTime o DateTime
        public int Total_pp { get; set; }
        public int Total_h { get; set; }
        public int Total_ps { get; set; }
        public List<RegistroDefectos> Registro = new();

        public JornadaLaboral(LocalTime fechaF)
        {
            FechaI = DateTime.UtcNow;
            FechaF = fechaF;
        }

        public void buscar()
        {
            //TODO
        }

    }
}
