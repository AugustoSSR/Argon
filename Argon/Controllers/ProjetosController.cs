using Argon.Data;
using Argon.Filters;
using Argon.Models;
using Argon.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Argon.Controllers
{
    [PaginaParaUsuarioLogado]
    public class ProjetosController : Controller
    {
        private readonly IProjetosRepositorio _projetosRepositorio;
        private readonly DBContext _dbContext;
        public ProjetosController(IProjetosRepositorio projetosRepositorio
            , DBContext dBContext)
        {
            _projetosRepositorio = projetosRepositorio;
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            List<ProjetoModel> projetos = _projetosRepositorio.GetProjetos();
            return View(projetos);
        }

        public IActionResult Adicionar()
        {

            var empresasList = _dbContext.Empresas.Select(r => r.Nome);
            var viewModelEmpresas = new ProjetoModel
            {
                EmpresaList = new SelectList(empresasList)
            };

            var engenheiroList = _dbContext.Engenheiros.Select(r => r.Nome);
            var viewModelEngenheiros = new ProjetoModel
            {
                EngenheirosList = new SelectList(engenheiroList)
            };

            /// Dados que pretendo puxar.
            //List<EmpresasModel> empresasList = new List<EmpresasModel>();
            //List<EngenheirosModel> engenheiroList = new List<EngenheirosModel>();
            // Selecionar a tabela
            //empresasList = (from x in _dbContext.Empresas select x).ToList();
            //empresasList.Insert(0, new EmpresasModel { Id = 0, Nome = "Selecione a empresa" });
            //ViewBag.empresa = empresasList;

            //engenheiroList = (from x in _dbContext.Engenheiros select x).ToList();
            //engenheiroList.Insert(0, new EngenheirosModel { Id = 0, Nome = "Selecione o engenheiro" });
            //ViewBag.engenheiro = engenheiroList;
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
            try
            {
                bool apagado = _projetosRepositorio.Apagar(id);

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
        public IActionResult Adicionar(ProjetoModel projeto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _projetosRepositorio.Adicionar(projeto);
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
        public IActionResult Editar(ProjetoModel projeto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _projetosRepositorio.Atualizar(projeto);
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
