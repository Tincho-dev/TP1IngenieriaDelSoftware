using TP1IngenieriaDelSoftware.Model;

namespace TP1IngenieriaDelSoftware.Models
{
    public class HorarioDeControl
    {
        public List<Incidencia> Registro = new();

        public HorarioDeControl() { }

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

        public int GetNumRegistro()
        {
            return Registro.Count;
        }
    }
}
