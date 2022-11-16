namespace TP1IngenieriaDelSoftware.Models
{
    public class Color
    {
        public string Codigo { get; set; }
        public string? Descripcion { get; set; }

        public Color(string codigo, string? descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }

        public void Buscar()
        {
            //TODO
        }
        public void Agregar()
        {
            //TODO
        }
    }
}
