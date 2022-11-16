using NuGet.Packaging.Rules;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace TP1IngenieriaDelSoftware.Models
{
    public class Modelo
    {
        public Guid Id { get; set; }
        public string SKU { get; set; }
        public string Denominacion { get; set; }
        public uint Lim_inferiorO { get; set; }
        public uint Lim_supO { get; set; }
        public uint Lim_inferiorR { get; set; }
        public uint Lim_supR { get; set; }

        public Modelo(string sKU, string denominacion, uint lim_inferiorO, uint lim_supO, uint lim_inferiorR, uint lim_supR)
        {
            SKU = sKU;
            Denominacion = denominacion;
            Lim_inferiorO = lim_inferiorO;
            Lim_supO = lim_supO;
            Lim_inferiorR = lim_inferiorR;
            Lim_supR = lim_supR;
        }

        public Semaforo CrearSemaforo(uint sup, uint inf)
        {
            return new Semaforo(sup, inf);
        }

        public void Buscar()
        {
            //TODO
        }

        public void Agregar()
        {
            //TODO
        }

        public void ObtenerColores()
        {
            //TODO
        }

        public void Obtener()
        {
            //TODO
        }
    }

    
}
