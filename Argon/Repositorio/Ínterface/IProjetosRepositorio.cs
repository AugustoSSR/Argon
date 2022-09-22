using Argon.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Argon.Repositorio.Ínterface
{
    public interface IProjetosRepositorio
    {
        List<ProjetoModel> GetProjetos();
        ProjetoModel ListarPorID(int id);
        ProjetoModel Adicionar(ProjetoModel projeto);
        ProjetoModel Atualizar(ProjetoModel projeto);

        bool Apagar(int id);

    }
}
