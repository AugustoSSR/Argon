using Argon.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Argon.Repositorio.Ínterface
{
    public interface IEmpresasRepositorio
    {
        List<EmpresasModel> GetEmpresas();
        EmpresasModel ListarPorID(int id);
        EmpresasModel Adicionar(EmpresasModel empresas);
        EmpresasModel Atualizar(EmpresasModel empresas);

        bool Apagar(int id);

    }
}
