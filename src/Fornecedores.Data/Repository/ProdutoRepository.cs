using Fornecedores.Bussines.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fornecedores.Bussines.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Fornecedores.Data.Context;

namespace Fornecedores.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(FornecedorContext context) :base(context){}
        public async Task<Produto> ObterProdutoFornecedor(Guid Id)
        {
            return await Db.Produtos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        {
            return await Db.Produtos.AsNoTracking()
            .Include(f => f.Fornecedor)
            .OrderBy(p => p.Nome).ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
}