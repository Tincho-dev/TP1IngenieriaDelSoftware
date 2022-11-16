using TP1IngenieriaDelSoftware.Models;

namespace ModelTesting.UnitTests
{
    public class HorarioDeControlTesting
    {
        
        public static readonly DateTime _fechaInicio = DateTime.Now;
        public static readonly NodaTime.LocalTime _fechaFin = new(18, 0);
        public static readonly NodaTime.LocalTime _fechaFinCambiada = new(14, 0);
        public HorarioDeControl HorarioDeControl = new(_fechaInicio, _fechaFin);

		public HorarioDeControlTesting()
        {
            //_fechaInicio = DateTime.Now;
            //_fechaFin = new(18, 0);

            HorarioDeControl HorarioDeControl = new(_fechaInicio,_fechaFin);
        }
        
        [Fact]
        public void RegistroIncidenciaConDefecto()
        {
            //preparacion
            PieSentido pie = PieSentido.DERECHO;
            Defecto defecto = new(TipoDefecto.OBSERVADO, "defecto de pureba");
            int cantidadActual = HorarioDeControl.TotalDefectos();
            int totalIncidencias = HorarioDeControl.TotalIncidencias();
            //ejecucuion
            HorarioDeControl.RegistrarDefecto(defecto,pie);
            //comprobacion
            Assert.Equal(cantidadActual + 1, HorarioDeControl.TotalDefectos());
            Assert.Equal(totalIncidencias + 1, HorarioDeControl.TotalIncidencias());
        }

        [Fact]
        public void RegistroIncidenciaParDePrimera()
        {
            //preparacion
            PieSentido pie = PieSentido.DERECHO;
            int cantidadActual = HorarioDeControl.TotalParesDePrimera();
            int totalIncidencias = HorarioDeControl.TotalIncidencias();
            //ejecucuion
            HorarioDeControl.RegistrarParDePrimera( pie);
            //comprobacion
            Assert.Equal(cantidadActual + 1, HorarioDeControl.TotalParesDePrimera());
            Assert.Equal(totalIncidencias + 1, HorarioDeControl.TotalIncidencias());
        }

        [Fact]
        public void FinalizarHorarioDeControlComprobarCambioDeHoraFin()
        {

            HorarioDeControl.Finalizar(_fechaFinCambiada);

            Assert.Equal(_fechaFinCambiada, HorarioDeControl.FechaFin);
        }
    }
}
