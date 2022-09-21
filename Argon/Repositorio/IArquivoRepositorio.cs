using Argon.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Argon.Repositorio
{
    public interface IArquivoRepositorio
    {
        List<ArquivosModel> GetArquivos();
        ArquivosModel ListarPorID(int id);
        ArquivosModel Adicionar(ArquivosModel arquivo);
        ArquivosModel Atualizar(ArquivosModel arquivo);

        bool Apagar(int id);

    }
}
