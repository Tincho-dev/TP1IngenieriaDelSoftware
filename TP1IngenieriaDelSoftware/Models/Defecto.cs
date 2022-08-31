using TP1IngenieriaDelSoftware.Models;

namespace API_TFI.Model
{
    public class Defecto
    {
        public Tipo Tipo { get; set; }
        public string Descripcion { get; set; }

        public Defecto(Tipo tipo, string descripcion)
        {
            Tipo = tipo;
            Descripcion = descripcion;
        }   
    }
}
