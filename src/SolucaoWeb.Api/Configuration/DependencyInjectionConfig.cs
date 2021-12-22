using Microsoft.Extensions.DependencyInjection;
using SolucaoWeb.Domain.Interfaces;
using SolucaoWeb.Domain.Services;
using SolucaoWeb.Infra.Context;
using SolucaoWeb.Infra.Repository;

namespace SolucaoWeb.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection SolvesDependencies(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            services.AddScoped<ITodoService, TodoService>();
            services.AddScoped<ITodoRepository, TodoRepository>();

            return services;
        }
    }
}