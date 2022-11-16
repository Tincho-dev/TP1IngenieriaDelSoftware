using NodaTime;
using TP1IngenieriaDelSoftware.Models;

namespace TP1IngenieriaDelSoftware.Models
{
    public class HorarioDeControl
    {
        public List<Incidencia> Registro = new();
        public DateTime FechaInicio;
        public NodaTime.LocalTime FechaFin;

        public HorarioDeControl(DateTime fechaInicio, NodaTime.LocalTime fechaFin) {
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public void RegistrarDefecto(Defecto defecto, PieSentido pie)// creo la incidencia o la recibo por parametro
        {
            DateTime hora = DateTime.Now;
            Incidencia incidencia = new(hora, defecto, pie, 1);
            Registro.Add(incidencia);
        }

        public void RegistrarParDePrimera(PieSentido pie)
        {

            DateTime hora = DateTime.Now;
            Incidencia incidencia = new(hora, pie, 1);

            Registro.Add(incidencia);
        }

        public void CorregirRegistroDeDefecto(Defecto defecto, PieSentido pie) 
        {
            DateTime hora = DateTime.Now;
            Incidencia incidencia = new(hora, defecto, pie, -1);

            Registro.Add(incidencia);
        }

        public void CorregirRegistroParDePrimera(PieSentido pie)
        {
            DateTime hora = DateTime.Now;
            Incidencia incidencia = new(hora, pie, -1);
            Registro.Add(incidencia);
        }

        public int TotalIncidencias()
        {
            return Registro.Count;
        }

        public int TotalDefectos()
        {
            int totalDefectos = 0;
            //int totalParesDePrimera = 0;
            for (int incidencia = 0; incidencia < Registro.Count; incidencia++)
            {
                if(Registro[incidencia].Defecto == null)
                {
                    //totalParesDePrimera += Registro[incidencia].Cantidad;
                }
                else
                {
                    totalDefectos += Registro[incidencia].Cantidad;
                }
            }

            return totalDefectos;
        }

        public int TotalParesDePrimera()
        {
            //int totalDefectos = 0;
            int totalParesDePrimera = 0;
            for (int incidencia = 0; incidencia < Registro.Count; incidencia++)
            {
                if (Registro[incidencia].Defecto == null)
                {
                    totalParesDePrimera += Registro[incidencia].Cantidad;
                }
                else
                {
                    //totalDefectos += Registro[incidencia].Cantidad;
                }
            }

            return totalParesDePrimera;
        }

        public void Finalizar(LocalTime fechaFin)
        {
            FechaFin= fechaFin;
        }
    }
}
