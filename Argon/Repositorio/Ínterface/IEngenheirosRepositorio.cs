using Argon.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Argon.Repositorio.Ínterface
{
    public interface IEngenheirosRepositorio
    {
        List<EngenheirosModel> GetEngenheiros();
        EngenheirosModel ListarPorID(int id);
        EngenheirosModel Adicionar(EngenheirosModel engenheiros);
        EngenheirosModel Atualizar(EngenheirosModel engenheiros);

        bool Apagar(int id);

    }
}
