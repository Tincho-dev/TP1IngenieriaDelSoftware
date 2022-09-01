using NodaTime;

namespace TP1IngenieriaDelSoftware.Model
{
    public class Turno
    {
        public int NumeroDeTurno { get; set; }//agregar al DC
        public LocalTime HoraDeInicio { get; set; }
        public LocalTime HoraDeFin { get; set; }

        public Turno(int numeroDeTurno, LocalTime horaDeInicio, LocalTime horaDeFin)
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
