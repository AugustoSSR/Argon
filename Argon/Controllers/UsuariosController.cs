using Argon.Filters;
using Argon.Models;
using Argon.Repositorio.Ínterface;
using Microsoft.AspNetCore.Mvc;

namespace Argon.Controllers
{
    [PaginaRestritaAdministracao]
    public class UsuariosController : Controller
    {
        private readonly IUsuariosRepositorio _usuariosRepositorio;
        public UsuariosController(IUsuariosRepositorio usuariosRepositorio)
        {
            _usuariosRepositorio = usuariosRepositorio;
        }
        public IActionResult Index()
        {
            List<UsuariosModel> usuarios = _usuariosRepositorio.GetUsuario();

            return View(usuarios);
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            UsuariosModel usuario = _usuariosRepositorio.ListarPorID(id);
            return View(usuario);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            UsuariosModel usuario = _usuariosRepositorio.ListarPorID(id);
            return View(usuario);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _usuariosRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = " Usuario apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = $" Seu usuario possui algum erro, tente novamente";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $" Seu usuario possui algum erro, tente novamente {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Copiar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(UsuariosModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuariosRepositorio.Adicionar(usuario);
                    TempData["MensagemSucesso"] = " usuario cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(usuario);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $" Seu usuario possui algum erro, tente novamente {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Editar(UsuarioSemSenhaModel usuarioSemSenha)
        {
            try
            {
                UsuariosModel usuario = null;
                if (ModelState.IsValid)
                {
                    usuario = new UsuariosModel()
                    {
                        Id = usuarioSemSenha.Id,
                        Nome = usuarioSemSenha.Nome,
                        Login = usuarioSemSenha.Login,
                        Email = usuarioSemSenha.Email,
                        Telefone = usuarioSemSenha.Telefone,
                        Perfil = usuarioSemSenha.Perfil
                    };
                    usuario = _usuariosRepositorio.Atualizar(usuario);
                    TempData["MensagemSucesso"] = " Usuario alterado com sucesso";
                    return RedirectToAction("Index");

                }
                return View(usuario);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $" Seu usuario possui algum erro, tente novamente. Segue o erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
