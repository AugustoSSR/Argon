using Argon.Models;
using Microsoft.EntityFrameworkCore;

namespace Argon.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<ProjetoModel> Projetos { get; set; }
    }
}
