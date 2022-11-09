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

        public OrdenDeProduccionTesting() {
            _turno = new Turno(1, new NodaTime.LocalTime(11, 0), new NodaTime.LocalTime(18,0));
            _op = new OrdenDeProduccion(1, _turno);
            _supervisor = new Usuario("Martin","abc","SUPERVISOR_DE_LINEA");
            _modelo = new("abc", "Test Shoes", 2, 3, 3, 4);
            _linea = new(1);
            _color = new("123","Test Color");
            _opCompleta = new(2, _linea, _modelo, _color, _turno);
        }

        [Fact]
        public void CreacionExitosaOrdenDeProduccionConNumeroYTurno()
        {
            //preparacion
            OrdenDeProduccion op;
            //ejecucion
            op = new(2, _turno);
            //comprobacion
            Assert.NotNull(op);
        }

        [Fact]
        public void CreacionExitosaOrdenDeProduccionConNumeroTurnoModeloColorYLinea()
        {
            OrdenDeProduccion op;

            op = new(2, _linea,_modelo,_color,_turno);
            
            Assert.NotNull(op);
        }

        [Fact]
        public void AsignarModeloAOrdenDeProduccionConNumeroYTurno()
        {
            OrdenDeProduccion op;
            op = new(2, _turno);
            op.AsignarModelo(_modelo);

            Assert.Equal(_modelo, op.Modelo);
        }

        [Fact]
        public void ConfirmarOrdenDeProduccionConNumeroYTurnoAsignandoModeloLineaYColor()
        {
            OrdenDeProduccion op;
            op = new(2, _turno);
            op.Confirmar(_linea,_color,_modelo);

            Assert.Equal(_opCompleta, op);
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
