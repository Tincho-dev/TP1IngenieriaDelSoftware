namespace TP1IngenieriaDelSoftware.Models
{
   
    public class Linea
    {
        public int Numero { get; set; }
        public EstadoDisponibilidad Estado { get; set; } 

        public Linea (int NumeroDeLinea)
        {
            this.Numero = NumeroDeLinea;
            Estado = EstadoDisponibilidad.DISPONIBLE;
        }
    }
}
