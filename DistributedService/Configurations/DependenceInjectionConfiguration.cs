using Application.Acesso.AcessoModule.Services;
using Domain.Acesso.UsuarioAgreggate;
using Infrastructure.Data.Context.Cadastro;
using Infrastructure.Data.Context.Cadastro.Repository.Acesso;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configurations
{
    public static class DependenceInjectionConfiguration
    {
        public static void AddDependenceInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IUsuarioRepository<AcessoContext>, UsuarioRepository>();
        }
    }
}