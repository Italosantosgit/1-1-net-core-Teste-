using Microsoft.EntityFrameworkCore;
using teste1para1.Models;

namespace teste1para1.Models
{
    public class TesteDB : DbContext
    {
        public TesteDB(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasKey(c => c.ClienteId);

            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Enderecos)
                .WithOne(c => c.Clientes)
                .HasForeignKey<Endereco>(e => e.ClienteRef);

        }


        public DbSet<teste1para1.Models.Cliente> Cliente { get; set; }


    }
}
