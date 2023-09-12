using Aula1_aspnet.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula1_aspnet.Data
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ContatoModel> Contatos { get; set; }

    }
}
