using Microsoft.AspNetCore.Mvc;

namespace Argon.Controllers
{
    public class ProjetosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        public IActionResult Copiar()
        {
            return View();
        }
    }
}
