using NodaTime;
using TP1IngenieriaDelSoftware.Models;

namespace TP1IngenieriaDelSoftware.Model
{
    public class JornadaLaboral
    {
 
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }// cambair todos o por LocalTime o DateTime
        public int Total_pp { get; set; }
        public int Total_h { get; set; }
        public int Total_ps { get; set; }
        public List<HorarioDeControl> historialDeControl { get; set; }

        public JornadaLaboral(DateTime fechaI, DateTime fechaF)
        {
            FechaInicio = fechaI;
            FechaFin = fechaF;
        }

        public void buscar()
        {
            //TODO
        }

    }
}
