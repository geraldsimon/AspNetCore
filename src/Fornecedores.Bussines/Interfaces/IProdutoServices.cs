using Fornecedores.Bussines.Models;
using System;
using System.Threading.Tasks;

namespace Fornecedores.Bussines.Interfaces
{
    public interface IProdutoServices : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}