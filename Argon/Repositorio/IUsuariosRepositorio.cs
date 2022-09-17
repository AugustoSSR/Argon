using Argon.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Argon.Repositorio
{
    public interface IUsuariosRepositorio
    {
        UsuariosModel BuscarPorEmail(string email, string login);
        UsuariosModel BuscarPorLogin(string login);
        List<UsuariosModel> GetUsuario();
        UsuariosModel ListarPorID(int id);
        UsuariosModel Adicionar(UsuariosModel usuario);
        UsuariosModel Atualizar(UsuariosModel usuario);
        UsuariosModel AlterarSenha(AlterarSenhaModel alterarSenhaModel);


        bool Apagar(int id);

    }
}
