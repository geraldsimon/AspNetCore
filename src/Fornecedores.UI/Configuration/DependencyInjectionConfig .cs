using Fornecedores.Bussines.Interfaces;
using Fornecedores.Bussines.Notifications;
using Fornecedores.Data.Context;
using Fornecedores.Data.Repository;
using Fornecedores.UI.Extensions;
using Fornecedores.UI.Services;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace Fornecedores.UI.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<FornecedorContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedoreRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorServices, FornecedorServices>();
            services.AddScoped<IProdutoServices, ProdutoServices>();

            return services;
        }
    }
}