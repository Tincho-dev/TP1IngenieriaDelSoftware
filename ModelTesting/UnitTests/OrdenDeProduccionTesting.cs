using TP1IngenieriaDelSoftware.Model;
using TP1IngenieriaDelSoftware.Models;

namespace ModelTesting
{
    public class OrdenDeProduccionTesting
    {   
        private readonly Turno _turno;
        private readonly OrdenDeProduccion _op;
        private readonly Usuario _supervisor;

        public OrdenDeProduccionTesting() {
            _turno = new Turno(1, new NodaTime.LocalTime(11, 0), new NodaTime.LocalTime(18,0));
            _op = new OrdenDeProduccion(1, _turno);
            _supervisor = new Usuario("Martin","abc","SUPERVISOR_DE_LINEA");
        }

        [Fact]
        public void CreacionExitosaOrdenDeProduccion()
        {
            //preparacion
            OrdenDeProduccion op;
            //ejecucion
            op = new(2, _turno);
            //comprobacion
            Assert.NotNull(op);
        }

        [Fact]
        public void AsociarSupervisorAOrdenDeProduccionExistente()
        {
            OrdenDeProduccion op;
            op = new(2, _turno);

            
            Assert.NotNull(op);
        }
    }
}
