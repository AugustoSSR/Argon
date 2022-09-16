using Argon.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Argon.Controllers
{
    [PaginaParaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
