using Argon.Models;

namespace Argon.Helper
{
    public interface ISessao
    {
        void criarSessaoUsuario(UsuariosModel usuariosModel);
        void removerSessaoUsuario();
        UsuariosModel BuscarSessaoUsuario();
    }
}
