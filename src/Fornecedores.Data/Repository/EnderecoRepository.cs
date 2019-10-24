using Fornecedores.Bussines.Interfaces;
using Fornecedores.Bussines.Models;
using Fornecedores.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Fornecedores.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(FornecedorContext context) : base(context) { }
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
             .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}