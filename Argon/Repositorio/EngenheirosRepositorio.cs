using Argon.Data;
using Argon.Models;

namespace Argon.Repositorio
{
    public class EngenheirosRepositorio : IEngenheirosRepositorio
    {
        private readonly DBContext _bancoContext;
        public EngenheirosRepositorio(DBContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public EngenheirosModel ListarPorID(int id)
        {
            return _bancoContext.Engenheiros.FirstOrDefault(x => x.Id == id);
        }
        public List<EngenheirosModel> GetEngenheiros()
        {
            // listagem de Engenheiross
            return _bancoContext.Engenheiros.ToList();
        }
        public EngenheirosModel Adicionar(EngenheirosModel Engenheiros)
        {
            UsuariosModel usuario = new UsuariosModel();
            // Inserção do banco de dados.
            Engenheiros.dataCadastro = DateTime.Now;
            Engenheiros.nomeCadastro = usuario.Nome;
            _bancoContext.Engenheiros.Add(Engenheiros);
            _bancoContext.SaveChanges();
            return Engenheiros;
        }

        public EngenheirosModel Atualizar(EngenheirosModel Engenheiros)
        {
            EngenheirosModel EngenheirosDB = ListarPorID(Engenheiros.Id);
            UsuariosModel Usuario = new UsuariosModel();
            if (EngenheirosDB == null) throw new System.Exception("Houve um erro na atualização do Engenheiros.");
            EngenheirosDB.Nome = Engenheiros.Nome;
            EngenheirosDB.CPF = Engenheiros.CPF;
            EngenheirosDB.CREA = Engenheiros.CREA;
            EngenheirosDB.Email = Engenheiros.Email;
            EngenheirosDB.dataVencimento = Engenheiros.dataVencimento;
            EngenheirosDB.nomeAlteracao = Usuario.Nome;
            EngenheirosDB.dataAlteracao = DateTime.Now;

            _bancoContext.Engenheiros.Update(EngenheirosDB);
            _bancoContext.SaveChanges();

            return EngenheirosDB;
        }

        public bool Apagar(int id)
        {
            EngenheirosModel EngenheirosDB = ListarPorID(id);

            if (EngenheirosDB == null) throw new System.Exception("Houve um erro na deleção do Engenheiros.");

            _bancoContext.Engenheiros.Remove(EngenheirosDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
