using Fornecedores.UI.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fornecedores.UI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<FornecedorViewModel> FornecedorViewModel { get; set; }
        //public DbSet<ProdutoViewModel> ProdutoViewModel { get; set; }
        //public DbSet<EnderecoViewModel> EnderecoViewModel { get; set; }
    }
}
