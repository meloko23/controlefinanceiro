using AppMvcControleFinanceiro.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppMvcControleFinanceiro.Context
{
    public class ControleFinanceiroContext : DbContext
    {
		public ControleFinanceiroContext(DbContextOptions<ControleFinanceiroContext> options) : base(options)
        {
            
        }

		public DbSet<Pessoa> Pessoas { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Pessoa>()
                        .HasKey(p => new { p.Id });
            
			modelBuilder.Entity<Pessoa>()
                        .HasIndex(p => new { p.Cpf })
                        .IsUnique();
		}

    }
}