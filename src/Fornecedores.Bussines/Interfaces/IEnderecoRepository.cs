using Fornecedores.Bussines.Models;
using System;
using System.Threading.Tasks;

namespace Fornecedores.Bussines.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}