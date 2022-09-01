using Microsoft.AspNetCore.Mvc;

namespace TP1IngenieriaDelSoftware.Controllers
{
    public class IniciarOpController : Controller
    {
        public void IniciarOp()
        {
            AdministradorIniciarOp admin = new();
        }





        public IActionResult Index()
        {
            return View();
        }
    }
}
