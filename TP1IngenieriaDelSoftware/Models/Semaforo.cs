using Microsoft.EntityFrameworkCore.Metadata;

namespace TP1IngenieriaDelSoftware.Model
{
    public enum color
    {
        ROJO,
        AMARILLO,
        VERDE
    }

    public class Semaforo //
    {
        public uint LimiteSuperior;
        public uint LimiteInferior;
        public color Color = color.VERDE;

        public Semaforo(uint limiteSuperior, uint limiteInferior){
           this.LimiteSuperior = limiteSuperior;
           this.LimiteInferior = limiteInferior;
        }

        public void EstablecerColor(int cantidadDefectos)
        {
            if(cantidadDefectos >= LimiteInferior && cantidadDefectos < LimiteSuperior)
            {
                this.Color = color.AMARILLO;
            }else if(cantidadDefectos < LimiteInferior)
            {
                this.Color=color.VERDE;
            }else if(cantidadDefectos == LimiteSuperior)
            {

            }

        }
    }
}
