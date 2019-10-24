using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace Fornecedores.UI.Extensions
{
    [HtmlTargetElement("*", Attributes = "supress-by-clain-name")]
    [HtmlTargetElement("*", Attributes = "supress-by-clain-value")]
    public class ApagaElementoByClaimTagHelper : TagHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApagaElementoByClaimTagHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HtmlAttributeName("supress-by-clain-name")]
        public string IdentityClaimName { get; set; }

        [HtmlAttributeName("supress-by-clain-value")]
        public string IdentityClaimValue { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var temAcesso = CustomAuthorization.ValidarClaimsUsuario(_httpContextAccessor.HttpContext, IdentityClaimName, IdentityClaimValue);
            if (temAcesso) return;

            output.SuppressOutput();
        }
    }
}