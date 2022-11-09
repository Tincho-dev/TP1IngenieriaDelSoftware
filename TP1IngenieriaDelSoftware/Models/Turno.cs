using NodaTime;

namespace TP1IngenieriaDelSoftware.Model
{
    public class Turno
    {
        public int NumeroDeTurno { get; set; }//agregar al DC
        public NodaTime.LocalTime HoraDeInicio { get; set; }
        public NodaTime.LocalTime HoraDeFin { get; set; }

        public Turno(int numeroDeTurno, NodaTime.LocalTime horaDeInicio, NodaTime.LocalTime horaDeFin)
        {
            NumeroDeTurno = numeroDeTurno;
            HoraDeInicio = horaDeInicio;
            HoraDeFin = horaDeFin;
        }

        public void ObtenerHoras()
        {
            //TODO
        }
        public void Buscar()
        {
            //TODO
        }
    }
}
