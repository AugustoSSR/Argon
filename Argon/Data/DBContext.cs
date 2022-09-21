using Argon.Models;
using Microsoft.EntityFrameworkCore;

namespace Argon.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
        public DbSet<ProjetoModel> Projetos { get; set; }
        public DbSet<UsuariosModel> Usuarios { get; set; }
        public DbSet<EmpresasModel> Empresas { get; set; }
        public DbSet<EngenheirosModel> Engenheiros { get; set; }
        public DbSet<ArquivosModel> Arquivos { get; set; }
    }
}
