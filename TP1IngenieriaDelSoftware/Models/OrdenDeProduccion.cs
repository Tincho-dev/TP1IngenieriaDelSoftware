using Microsoft.AspNetCore.Mvc.ModelBinding;
using NodaTime;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;

namespace TP1IngenieriaDelSoftware.Models
{
    public class OrdenDeProduccion
    {
        public int? NumeroOP { get; set; }
        public Linea? Linea { get; set; }
        public EstadoOrdenDeProduccion? Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Modelo? Modelo { get; set; }
        public Color? Color { get; set; }
        public List<JornadaLaboral>? Jornadas { get; set; } = new();
        public Semaforo? SemaforoObservado { get; set; }
        public Semaforo? SemaforoReproceso { get; set; }
        public string LINEA_OCUPADA_TEXT_EXCEPTION = "Linea Ocupada, por favor seleccione otra";

        public OrdenDeProduccion(int numeroOP, Linea linea, Modelo modelo, Color color, Turno turno, DateTime fechaInicio)
        {
            if (linea.Estado == EstadoDisponibilidad.DISPONIBLE)
            {
                NumeroOP = numeroOP;
                Linea = linea;
                Estado = EstadoOrdenDeProduccion.INICIADA;
                Modelo = modelo;
                Color = color;
                fechaInicio = FechaInicio;

                linea.Estado = EstadoDisponibilidad.OCUPADA;

                SemaforoReproceso = new Semaforo(modelo.Lim_supR, modelo.Lim_inferiorR);
                SemaforoObservado = new Semaforo(modelo.Lim_supO, modelo.Lim_inferiorO);
                Jornadas.Add(new JornadaLaboral(DateTime.Now, turno.HoraDeFin));
            }
            else
            {
                throw new Exception(LINEA_OCUPADA_TEXT_EXCEPTION);
            }
            

        }

        public OrdenDeProduccion(int numeroOP, Turno turno, DateTime fechaInicio)
        {
            NumeroOP = numeroOP;
            Estado = EstadoOrdenDeProduccion.INICIADA;
            fechaInicio = FechaInicio;


            Jornadas.Add(new JornadaLaboral(DateTime.Now,turno.HoraDeFin));
        }

        public OrdenDeProduccion()
        {
        }

        public void Confirmar(Linea lineaActual, Color color, Modelo modelo)
        {
            if(lineaActual.Estado == EstadoDisponibilidad.DISPONIBLE) {
                this.Linea = lineaActual;
                this.Color = color;
                this.AsignarModelo(modelo);
                lineaActual.Estado = EstadoDisponibilidad.OCUPADA;
            } else
            {
                throw new Exception(LINEA_OCUPADA_TEXT_EXCEPTION);
            }
        }

        public void AsignarModelo(Modelo modelo) 
        {
            this.Modelo = modelo;

            SemaforoReproceso = modelo.CrearSemaforo(modelo.Lim_supR, modelo.Lim_inferiorR);//agregar responsabilidad en DC
            SemaforoObservado = modelo.CrearSemaforo(modelo.Lim_supO, modelo.Lim_inferiorO);
        }

        public void BuscarOP()
        {
            //TODO
        }

        
    }
}
