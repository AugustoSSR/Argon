using Argon.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Argon.Repositorio
{
    public interface IProjetosRepositorio
    {
        ProjetoModel ListarPorID(int id);
        List<ProjetoModel> GetProjetos();
        ProjetoModel Adicionar(ProjetoModel projeto);
        ProjetoModel Atualizar(ProjetoModel projeto);

        bool Apagar(int id);

    }
}
