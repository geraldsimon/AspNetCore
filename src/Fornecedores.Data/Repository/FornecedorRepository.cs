using Fornecedores.Bussines.Interfaces;
using Fornecedores.Bussines.Models;
using Fornecedores.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Fornecedores.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedoreRepository
    {
        public FornecedorRepository(FornecedorContext context) : base(context) { }
        public async Task<Fornecedor> ObterFornecedorEndereco(Guid Id)
        {
            return await Db.Fornecedores.AsNoTracking()
             .Include(f => f.Endereco)
             .FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid Id)
        {
            return await Db.Fornecedores.AsNoTracking()
           .Include(f => f.Produtos)
           .Include(f => f.Endereco)
           .FirstOrDefaultAsync(p => p.Id == Id);
        }
    }
}