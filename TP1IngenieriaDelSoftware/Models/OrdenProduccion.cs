using Microsoft.AspNetCore.Mvc.ModelBinding;
using NodaTime;

namespace API_TFI.Model
{
    public class OrdenProduccion
    {
        public int NumeroOP { get; set; }
        public Linea Linea { get; set; }
        public EstadoOperacion Estado { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public Modelo Modelo { get; set; }
        public Color Color { get; set; }
        public List<JornadaLaboral> Jornadas { get; set; } = new();
        public Semaforo Semaforo { get; set; }

        public OrdenProduccion(int numeroOP, Linea linea, Modelo modelo, Color color,  Semaforo semaforo)
        {
            NumeroOP = numeroOP;
            Linea = linea;
            Estado = EstadoOperacion.INICIADA;
            Fecha_Inicio = DateTime.UtcNow;
            Modelo = modelo;
            Color = color;
            Semaforo = semaforo;
        }


        public OrdenProduccion (int Numero, DateTime FechaDeInicio)//crear()
        {
            this.NumeroOP = Numero;
            this.Fecha_Inicio = FechaDeInicio;
        }
        public void BuscarOP()
        {
            //TODO
        }
        public void AsignarModelo(Modelo modelo)
        {
            this.Modelo = modelo;
        }

    }
}
