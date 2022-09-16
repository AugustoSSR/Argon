using Argon.Models;
using Argon.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Argon.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuariosRepositorio _usuariosRepositorio;
        public LoginController(IUsuariosRepositorio usuariosRepositorio)
        {
            _usuariosRepositorio = usuariosRepositorio;
        }

        public IActionResult Index()
        {
            return View();
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
