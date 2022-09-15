using Argon.Models;
using Argon.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Argon.Controllers
{
    public class ProjetosController : Controller
    {
        private readonly IProjetosRepositorio _projetosRepositorio;
        public ProjetosController(IProjetosRepositorio projetosRepositorio)
        {
            _projetosRepositorio = projetosRepositorio;
        }
        public IActionResult Index()
        {
            List<ProjetoModel> projetos = _projetosRepositorio.GetProjetos();

            return View(projetos);
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            ProjetoModel projeto = _projetosRepositorio.ListarPorID(id);
            return View(projeto);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ProjetoModel projeto = _projetosRepositorio.ListarPorID(id);
            return View(projeto);
        }

        public IActionResult Apagar(int id)
        {
            _projetosRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        public IActionResult Copiar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(ProjetoModel projeto)
        {
            _projetosRepositorio.Adicionar(projeto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(ProjetoModel projeto)
        {
            _projetosRepositorio.Atualizar(projeto);
            return RedirectToAction("Index");
        }
    }
}
