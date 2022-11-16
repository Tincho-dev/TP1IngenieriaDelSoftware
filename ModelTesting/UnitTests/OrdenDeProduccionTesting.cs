using TP1IngenieriaDelSoftware.Model;

namespace ModelTesting
{
    public class OrdenDeProduccionTesting
    {   
        private readonly Turno _turno;
        private readonly OrdenDeProduccion _opCompleta;
        private readonly OrdenDeProduccion _op;
        private readonly Usuario _supervisor;
        private readonly Modelo _modelo;
        private readonly Color _color;
        private readonly Linea _linea;
        private readonly DateTime _fechaInicio;
        private readonly int _numeroOrdenDeProduccion;

        public OrdenDeProduccionTesting() {
            _turno = new Turno(1, new NodaTime.LocalTime(11, 0), new NodaTime.LocalTime(18,0));
            _op = new OrdenDeProduccion(1, _turno, _fechaInicio);
            _supervisor = new Usuario("Martin","abc","SUPERVISOR_DE_LINEA");
            _modelo = new("abc", "Test Shoes", 2, 3, 3, 4);
            _linea = new(1);
            _color = new("123","Test Color");
            _opCompleta = new(2, _linea, _modelo, _color, _turno,_fechaInicio);
            _numeroOrdenDeProduccion = 2;
        }

        [Fact]
        public void CreacionExitosaOrdenDeProduccionConNumeroYTurno()
        {
            //preparacion
            OrdenDeProduccion op;
            //ejecucion
            op = new(2, _turno, _fechaInicio);
            //comprobacion
            Assert.NotNull(op);
        }

        [Fact]
        public void CreacionExitosaOrdenDeProduccionConNumeroTurnoModeloColorYLinea()
        {
            OrdenDeProduccion op;

            op = new(2, _linea,_modelo,_color,_turno, _fechaInicio);
            
            Assert.NotNull(op);
        }

        [Fact]
        public void AsignarModeloAOrdenDeProduccionConNumeroYTurno()
        {
            OrdenDeProduccion op;
            op = new(_numeroOrdenDeProduccion, _turno, _fechaInicio);
            op.AsignarModelo(_modelo);

            Assert.Equal(_modelo, op.Modelo);
            Assert.Equal(_color, op.Color);
            Assert.Equal(_fechaInicio, op.FechaInicio);
        }

        [Fact]
        public void ConfirmarOrdenDeProduccionConNumeroYTurnoAsignandoModeloLineaYColor()
        {
            OrdenDeProduccion op;
            op = new(2, _turno, _fechaInicio);
            op.Confirmar(_linea,_color,_modelo);

            Assert.Equal(_opCompleta, op);
            Assert.Equal(_modelo, op.Modelo);
            Assert.Equal(_color, op.Color);
            Assert.Equal(_fechaInicio, op.FechaInicio);
        }

        [Fact]
        public void CrearOrdenDeProduccionVacia()
        {
            OrdenDeProduccion op;
            op = new();
            Assert.NotNull(op);
        }
    }
}
