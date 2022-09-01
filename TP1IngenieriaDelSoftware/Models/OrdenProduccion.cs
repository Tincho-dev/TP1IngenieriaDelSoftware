using Microsoft.AspNetCore.Mvc.ModelBinding;
using NodaTime;

namespace TP1IngenieriaDelSoftware.Model
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
        public Semaforo SemaforoObservado { get; set; }
        public Semaforo SemaforoReproceso { get; set; }

        public OrdenProduccion(int numeroOP, Linea linea, Modelo modelo, Color color, Turno turno)
        {
            NumeroOP = numeroOP;
            Linea = linea;
            Estado = EstadoOperacion.INICIADA;
            Fecha_Inicio = DateTime.UtcNow;
            Modelo = modelo;
            Color = color;

            SemaforoReproceso = new Semaforo(modelo.Lim_supR, modelo.Lim_inferiorR);
            SemaforoObservado = new Semaforo(modelo.Lim_supO, modelo.Lim_inferiorO);
            Jornadas.Add(new JornadaLaboral(turno.HoraDeFin));

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
