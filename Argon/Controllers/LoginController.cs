using Argon.Helper;
using Argon.Models;
using Argon.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Argon.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuariosRepositorio _usuariosRepositorio;
        private readonly ISessao _sessao;
        public LoginController(IUsuariosRepositorio usuariosRepositorio, 
            ISessao sessao)
        {
            _usuariosRepositorio = usuariosRepositorio;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            // se o usuario estive logado, redirecionar para a home
            if (_sessao.BuscarSessaoUsuario() != null) return RedirectToAction("Index", "Home");
            return View();
        }

        public IActionResult Sair()
        {
            _sessao.removerSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    UsuariosModel usuario = _usuariosRepositorio.BuscarPorLogin(loginModel.Login);
                    if(usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            _sessao.criarSessaoUsuario(usuario);
                            TempData["MensagemSucesso"] = $"Você logou com sucesso. Sejá bem vindo {usuario.Nome}";
                            return RedirectToAction("Index", "Home");
                        }
                        
                        TempData["MensagemErro"] = "A senha do usuário é inválida. Por favor, tente novamente.";
                    }
                    TempData["MensagemErro"] = "Usuário e/ou senha inválido(s). Por favor, tente novamente.";
                }
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar o seu login. Erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
