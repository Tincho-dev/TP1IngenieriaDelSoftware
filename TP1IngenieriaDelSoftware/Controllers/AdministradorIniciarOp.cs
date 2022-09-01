using Microsoft.AspNetCore.Mvc;
using NodaTime;
using TP1IngenieriaDelSoftware.Data;
using TP1IngenieriaDelSoftware.Model;
using TP1IngenieriaDelSoftware.Models;

namespace TP1IngenieriaDelSoftware.Controllers
{
    public class AdministradorIniciarOp : Controller
    {
        public void IniciarOp(int numero)
        {
            //Empleado e = Sesion.ObtenerEmpleado();// como implementar singleton?
            MemoriaPersistente repo = new();
            Turno turnoActual = repo.BuscarTurno(DateTime.Today.Hour);
            List<Modelo> modelos = repo.Modelos;
            List<Color> colores = repo.Colores;
            List<Linea> lineasLibres = repo.LineasLibres();

            //devolver datos al usuario apra elegir Modelo, color y linea

            OrdenProduccion op = new(
                numero,
                turnoActual
                );
        }

        public void ConfirmarOP()
        {

        }




        public IActionResult Index()
        {
            return View();
        }
    }
}
