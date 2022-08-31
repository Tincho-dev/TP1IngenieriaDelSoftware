using NodaTime;
using TP1IngenieriaDelSoftware.Models;

namespace API_TFI.Model
{
    public class JornadaLaboral
    {
 
        public LocalTime FechaI { get; set; }
        public LocalTime FechaF { get; set; }
        public int Total_pp { get; set; }
        public int Total_h { get; set; }
        public int Total_ps { get; set; }
        public List<RegistroDefectos> Registro = new();

        public JornadaLaboral(LocalTime fechaI, LocalTime fechaF, int total_pp, int total_h, int total_ps, List<RegistroDefectos> registro)
        {
            FechaI = fechaI;
            FechaF = fechaF;
            Total_pp = total_pp;
            Total_h = total_h;
            Total_ps = total_ps;
            Registro = registro;
        }

        public void buscar()
        {
            //TODO
        }

    }
}
