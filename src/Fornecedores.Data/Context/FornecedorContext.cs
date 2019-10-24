using Microsoft.EntityFrameworkCore;
using System.Linq;
using Fornecedores.Bussines.Models;

namespace Fornecedores.Data.Context
{
    public class FornecedorContext: DbContext
    {
        public FornecedorContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FornecedorContext).Assembly);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}