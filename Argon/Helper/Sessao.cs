using Argon.Models;
using Newtonsoft.Json;

namespace Argon.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public Sessao(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public UsuariosModel BuscarSessaoUsuario()
        {
            string usuarioSessao = _contextAccessor.HttpContext.Session.GetString("SessaoUsuarioLogado");

            if (string.IsNullOrEmpty(usuarioSessao)) return null;

            return JsonConvert.DeserializeObject<UsuariosModel>(usuarioSessao);
        }

        public void criarSessaoUsuario(UsuariosModel usuariosModel)
        {
            string valor = JsonConvert.SerializeObject(usuariosModel);
            _contextAccessor.HttpContext.Session.SetString("SessaoUsuarioLogado", valor);
        }

        public void removerSessaoUsuario()
        {
            _contextAccessor.HttpContext.Session.Remove("SessaoUsuarioLogado");
        }
    }
}
