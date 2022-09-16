
using Argon.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Argon.Controllers
{
    [PaginaParaUsuarioLogado]
    public class ArquivoController : Controller
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
    }
}
