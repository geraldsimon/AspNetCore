using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fornecedores.Bussines.Models;

namespace Fornecedores.Bussines.Interfaces
{
    public interface IProdutoRepository: IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid Id);
    }
}