using Argon.Filters;
using Argon.Models;
using Argon.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Argon.Controllers
{
    [PaginaParaUsuarioLogado]
    public class ArquivosController : Controller
    {
        private readonly IArquivoRepositorio _arquivoRepositorio;
        public ArquivosController(IArquivoRepositorio arquivoRepositorio)
        {
            _arquivoRepositorio = arquivoRepositorio;
        }
        public IActionResult Index()
        {
            List<ArquivoModel> projetos = _arquivoRepositorio.GetArquivo();

            return View(projetos);
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            ArquivoModel projeto = _arquivoRepositorio.ListarPorID(id);
            return View(projeto);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ArquivoModel projeto = _arquivoRepositorio.ListarPorID(id);
            return View(projeto);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _arquivoRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = " Projeto apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = $" Seu projeto possui algum erro, tente novamente";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $" Seu projeto possui algum erro, tente novamente {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Copiar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(ArquivoModel projeto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _arquivoRepositorio.Adicionar(projeto);
                    TempData["MensagemSucesso"] = " Projeto cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(projeto);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $" Seu projeto possui algum erro, tente novamente {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Editar(ArquivoModel projeto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _arquivoRepositorio.Atualizar(projeto);
                    TempData["MensagemSucesso"] = " Projeto alterado com sucesso";
                    return RedirectToAction("Index");

                }
                return View(projeto);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $" Seu projeto possui algum erro, tente novamente {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
