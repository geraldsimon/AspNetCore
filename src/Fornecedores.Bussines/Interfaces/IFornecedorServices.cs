using Fornecedores.Bussines.Models;
using System;
using System.Threading.Tasks;

namespace Fornecedores.Bussines.Interfaces
{
    public interface IFornecedorServices: IDisposable
    {
        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task AtualizaEndereco(Endereco endereco);
        Task Remover(Guid id);
    }
}