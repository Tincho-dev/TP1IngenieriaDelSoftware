using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1IngenieriaDelSoftware.Models;

namespace ModelTesting.UnitTests
{
    public class HorarioDeControlTesting
    {
        public HorarioDeControl HorarioDeControl;
        public readonly DateTime _fechaInicio;
        public readonly DateTime _fechaFin;

        public HorarioDeControlTesting()
        {
            HorarioDeControl HorarioDeControl = new(_fechaInicio,_fechaFin);
        }
        
        [Fact]
        public void RegistroIncidenciaConDefecto()
        {

        }
        [Fact]
        public void RegistroIncidenciaParDePrimera()
        {

        }


    }
}
