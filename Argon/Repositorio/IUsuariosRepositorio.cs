using Argon.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Argon.Repositorio
{
    public interface IUsuariosRepositorio
    {
        List<UsuariosModel> GetUsuario();
        UsuariosModel ListarPorID(int id);
        UsuariosModel Adicionar(UsuariosModel usuario);
        UsuariosModel Atualizar(UsuariosModel usuario);

        bool Apagar(int id);

    }
}
