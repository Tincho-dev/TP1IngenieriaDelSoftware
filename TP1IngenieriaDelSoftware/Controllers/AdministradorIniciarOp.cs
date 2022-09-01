using Microsoft.AspNetCore.Mvc;
using TP1IngenieriaDelSoftware.Models;

namespace TP1IngenieriaDelSoftware.Controllers
{
    public class AdministradorIniciarOp : Controller
    {
        public void IniciarOp()
        {
            Empleado e = Sesion.ObtenerEmpleado();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
