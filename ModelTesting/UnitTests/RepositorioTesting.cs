using TP1IngenieriaDelSoftware.Exceptions;
using TP1IngenieriaDelSoftware.Models;
using TP1IngenieriaDelSoftware.Repositorio;

namespace ModelTesting.UnitTests
{
    public class RepositorioTesting
    {
        private MemoriaPersistente repositorio;
        private List<OrdenDeProduccion> ordenes;
        private List<Linea>? lineas;
        private List<Modelo>? modelos;
        private List<Color>? colores;

        public RepositorioTesting()
        {
            repositorio = new MemoriaPersistente();
            repositorio.SetData();
            ordenes = new();
            lineas = repositorio.GetLineas();
            modelos = repositorio.GetModelos();
            colores = repositorio.GetColores();

        }

        [Fact]
        public void AsignarLineaOcupadaAOrdenDeProduccion()
        {
            //Preparacion
            OrdenDeProduccion op;
            //OrdenDeProduccion op2 = new(234,new Linea(47,EstadoDisponibilidad.DISPONIBLE),new Modelo("","",4,5,6,7),new Turno(3,new NodaTime.LocalTime(18,0)),DateTime.now);
            Linea l1 = new(234);
            l1.Estado = EstadoDisponibilidad.OCUPADA;

            //Ejecucion
            op = new OrdenDeProduccion(34556, l1, repositorio.Modelos[2], repositorio.Colores[0], repositorio.Turnos[2], DateTime.Now);

            //Comprobacion
            Assert.Throws<DomainException>(() =>
            {
                _ = new OrdenDeProduccion(34556, l1, repositorio.Modelos[2], repositorio.Colores[0], repositorio.Turnos[2], DateTime.Now);
            });
		}
    }
}
