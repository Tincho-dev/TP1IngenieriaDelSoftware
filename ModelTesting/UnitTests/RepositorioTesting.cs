using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1IngenieriaDelSoftware.Model;
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
