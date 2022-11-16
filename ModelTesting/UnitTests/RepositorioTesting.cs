using TP1IngenieriaDelSoftware.Models;
using TP1IngenieriaDelSoftware.Repositorio;

namespace ModelTesting.UnitTests
{
    public class RepositorioTesting
    {
        private IRepositorio repositorio;
        private List<OrdenDeProduccion> ordenes;

        public RepositorioTesting()
        {
            repositorio = new RepositorioEnMemoria();
            ordenes = new();
        }
    }
}
