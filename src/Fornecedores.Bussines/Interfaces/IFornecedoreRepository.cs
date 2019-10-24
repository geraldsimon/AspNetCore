using System;
using System.Threading.Tasks;
using Fornecedores.Bussines.Models;

namespace Fornecedores.Bussines.Interfaces
{
    public interface IFornecedoreRepository: IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid Id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid Id);
    }
}