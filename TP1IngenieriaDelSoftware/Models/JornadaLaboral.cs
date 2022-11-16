using NodaTime;
using TP1IngenieriaDelSoftware.Models;

namespace TP1IngenieriaDelSoftware.Models
{
    public class JornadaLaboral
    {
 
        public DateTime FechaInicio { get; set; }
        public NodaTime.LocalTime FechaFin { get; set; }
        public int Total_pp { get; set; }
        public int Total_h { get; set; }
        public int Total_ps { get; set; }
        public List<HorarioDeControl> historialDeControl { get; set; }

        public JornadaLaboral(DateTime fechaI, NodaTime.LocalTime fechaF)
        {
            FechaInicio = fechaI;
            FechaFin = fechaF;
            historialDeControl = new List<HorarioDeControl>();
        }

        public void AgregarHorarioDeControl()
        {
            DateTime fechaActual = DateTime.Now;
            NodaTime.LocalTime fechaFin = FechaFin;

            HorarioDeControl horarioDeControl = new HorarioDeControl(fechaActual, fechaFin);
            historialDeControl.Add(horarioDeControl);
        }

        public void buscar()
        {
            //TODO
        }

    }
}
