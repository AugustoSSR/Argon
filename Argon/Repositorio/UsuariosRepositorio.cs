using Argon.Data;
using Argon.Models;

namespace Argon.Repositorio
{
    public class UsuariosRepositorio : IUsuariosRepositorio
    {
        private readonly DBContext _bancoContext;
        public UsuariosRepositorio(DBContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public UsuariosModel ListarPorID(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Id == id);
        }
        public List<UsuariosModel> GetUsuario()
        {
            // listagem de projetos
            return _bancoContext.Usuarios.ToList();
        }
        public UsuariosModel Adicionar(UsuariosModel usuario)
        {
            // Inserção do banco de dados.
            usuario.dataCadastro = DateTime.Now;
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }

        public UsuariosModel Atualizar(UsuariosModel usuario)
        {
            UsuariosModel usuarioDB = ListarPorID(usuario.Id);

            if (usuarioDB == null) throw new System.Exception("Houve um erro na atualização do projeto.");
            usuarioDB.Nome = usuario.Nome;
            usuarioDB.Login = usuario.Login;
            usuarioDB.Email = usuario.Email;
            usuarioDB.Telefone = usuario.Telefone;
            usuarioDB.Perfil = usuario.Perfil;
            usuarioDB.dataAlteracao = DateTime.Now;

            _bancoContext.Usuarios.Update(usuarioDB);
            _bancoContext.SaveChanges();

            return usuarioDB;
        }

        public bool Apagar(int id)
        {
            UsuariosModel usuarioDB = ListarPorID(id);

            if (usuarioDB == null) throw new System.Exception("Houve um erro na deleção do projeto.");

            _bancoContext.Usuarios.Remove(usuarioDB);
            _bancoContext.SaveChanges();

            return true;
        }

    }
}
