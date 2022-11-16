using Microsoft.AspNetCore.Mvc;
using TP1IngenieriaDelSoftware.Data;
using TP1IngenieriaDelSoftware.Models;
using TP1IngenieriaDelSoftware.Repositorio;

namespace TP1IngenieriaDelSoftware.Controllers
{
    public class AdministradorIniciarOp : Controller
    {
        MemoriaPersistente repo = new();
        OrdenDeProduccion op = new();

        public void IniciarOp(int numero)
        {
            //Empleado e = Sesion.ObtenerEmpleado();// como implementar singleton?
            Turno turnoActual = repo.BuscarTurno(DateTime.Today.Hour);
            List<Modelo> modelos = repo.Modelos;
            List<Color> colores = repo.Colores;
            List<Linea> lineasLibres = repo.LineasLibres();

            //devolver datos al usuario apra elegir Modelo, color y linea

             op = new(
                numero,
                turnoActual,
                DateTime.Now
                );
        }

        public void ConfirmarOP(int numeroLinea, string sku, string codigoColor)
        {
            Linea? lineaActual = repo.Lineas.Find(l => l.Numero == numeroLinea);
            if (lineaActual == null)
                throw new Exception("Linea no encontrada");
            Modelo? modelo = repo.Modelos.Find(m => m.SKU == sku);
            if(modelo == null)
                throw new Exception("Modelo no encontrado");
            Color? color = repo.Colores.Find(c => c.Codigo == codigoColor);
            if (color == null)
                throw new Exception("Color no encontrado");

            op.Confirmar(lineaActual, color, modelo);

        }

        public IActionResult Index()
        {
            return View();
        }

        public bool AutenticarUsuario(string usuario, string contraseñaEncriptada)//gestorIniciarOp?
        {
            usuario = usuario.Trim();
            contraseñaEncriptada = contraseñaEncriptada.Trim();

            Usuario? usuarioReal = repo.Usuarios.Find(u => u.User == usuario);

            if (usuarioReal != null)
            {
                if (usuarioReal.ValidarContraseña(contraseñaEncriptada))
                {
                    return true;//autenticacion exitosa
                }
            }
            return false;
        }
    }
}
