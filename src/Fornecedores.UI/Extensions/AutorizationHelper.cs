using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Fornecedores.UI.Extensions
{
    public class PermicaoNescessaria : IAuthorizationRequirement
    {
        public string Permissao { get; set; }
        public PermicaoNescessaria(string permissao)
        {
            Permissao = permissao;
        }
    }

    public class PermicaoNescessariaHandler : AuthorizationHandler<PermicaoNescessaria>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermicaoNescessaria requisito)
        {
            if (context.User.HasClaim(match: c => c.Type == "Permissao" && c.Value.Contains(requisito.Permissao)))
            {
                context.Succeed(requisito);
            }

            return Task.CompletedTask;
        }
    }
}
