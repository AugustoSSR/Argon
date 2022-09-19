using Argon.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Argon.Repositorio
{
    public interface IArquivoRepositorio
    {
        List<ArquivoModel> GetArquivo();
        ArquivoModel ListarPorID(int id);
        ArquivoModel Adicionar(ArquivoModel arquivo);
        ArquivoModel Atualizar(ArquivoModel arquivo);

        bool Apagar(int id);

    }
}
