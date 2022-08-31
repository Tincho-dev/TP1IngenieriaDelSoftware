namespace TP1IngenieriaDelSoftware.Models
{

    public enum TipoDefecto
    {
        OBSERVADO,
        REPROCESO
    }
    public class Tipo
    {
        public TipoDefecto TipoDefecto { get; set; }

        public Tipo(TipoDefecto tipoDefecto)
        {
            TipoDefecto = tipoDefecto;
        }
    }
}
