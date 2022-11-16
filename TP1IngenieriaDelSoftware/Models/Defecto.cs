using TP1IngenieriaDelSoftware.Models;

namespace TP1IngenieriaDelSoftware.Models
{
    public class Defecto
    {
        public TipoDefecto Tipo { get; set; }
        public string Descripcion { get; set; }

        public Defecto(TipoDefecto tipo, string descripcion)
        {
            Tipo = tipo;
            Descripcion = descripcion;
        }   
    }
}
