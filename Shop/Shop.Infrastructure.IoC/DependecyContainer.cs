using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Interfaces;
using Shop.Application.Services;
using Shop.Domain.Interfaces;
using Shop.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Infrastructure.IoC
{
    public class DependecyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            // TODO  aqui é feita as injeções de dependencia considerando um ciclo de vida

            // através do AddScoped
            // Nota: pesquisar sobre Scoped, Singleton, e Transient
            // https://nelson-souza.medium.com/net-core-dependency-injection-1c1900d1bef
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

        }
    }
}
