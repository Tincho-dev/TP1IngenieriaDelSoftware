namespace TP1IngenieriaDelSoftware.Models
{
    public enum EstadoOperacion
    {
        INICIADA,
        PAUSADA,
        FINALIZADA
    }

    public class Estado
    {
        public EstadoOperacion estado; 

        public Estado (EstadoOperacion estado)
        {
            this.estado = estado;
        }
    }
}
