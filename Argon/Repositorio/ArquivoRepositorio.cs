using Argon.Data;
using Argon.Models;

namespace Argon.Repositorio
{
    public class ArquivoRepositorio : IArquivoRepositorio
    {
        private readonly DBContext _bancoContext;
        public ArquivoRepositorio(DBContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ArquivosModel ListarPorID(int id)
        {
            return _bancoContext.Arquivos.FirstOrDefault(x => x.Id == id);
        }
        public List<ArquivosModel> GetArquivos()
        {
            // listagem de Arquivoss
            return _bancoContext.Arquivos.ToList();
        }
        public ArquivosModel Adicionar(ArquivosModel Arquivos)
        {
            // Inserção do banco de dados.

            var usuario = new UsuariosModel();


            Arquivos.dataCadastro = DateTime.Now;
            Arquivos.nomeCadastro = usuario.Nome;
            _bancoContext.Arquivos.Add(Arquivos);
            _bancoContext.SaveChanges();
            return Arquivos;
        }

        public ArquivosModel Atualizar(ArquivosModel Arquivos)
        {
            ArquivosModel ArquivosDB = ListarPorID(Arquivos.Id);
            if (ArquivosDB == null) throw new System.Exception("Houve um erro na atualização do Arquivos.");
            ArquivosDB.Nome = Arquivos.Nome;
            ArquivosDB.numeroCaderno = Arquivos.numeroCaderno;
            ArquivosDB.Empresa = Arquivos.Empresa;
            ArquivosDB.Localidade = Arquivos.Localidade;
            ArquivosDB.dataAlteracao = DateTime.Now;

            _bancoContext.Arquivos.Update(ArquivosDB);
            _bancoContext.SaveChanges();

            return ArquivosDB;
        }

        public bool Apagar(int id)
        {
            ArquivosModel ArquivosDB = ListarPorID(id);

            if (ArquivosDB == null) throw new System.Exception("Houve um erro na deleção do Arquivos.");

            _bancoContext.Arquivos.Remove(ArquivosDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
