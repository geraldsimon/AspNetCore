using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Fornecedores.UI.Extensions
{
    public class AuditoriaFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {

        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }
    }
}