namespace API_TFI.Model
{
    public class Semaforo //
    {
        public uint LimiteSuperior;
        public uint LimiteInferior;


        public Semaforo(uint limiteSuperior, uint limiteInferior){
           this.LimiteSuperior = limiteSuperior;
           this.LimiteInferior = limiteInferior;
        }
    }
}
