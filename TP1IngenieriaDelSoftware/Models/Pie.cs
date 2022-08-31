namespace TP1IngenieriaDelSoftware.Models
{
    public enum PieSentido
    {
        DERECHO,
        IZQUIERDO
    }
    public class Pie
    {
        public PieSentido PieSentido { get; set; }

        public Pie(PieSentido pieSentido)
        {
            PieSentido = pieSentido;
        }
    }
}
