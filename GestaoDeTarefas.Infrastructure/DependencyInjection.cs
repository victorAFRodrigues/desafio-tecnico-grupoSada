using GestaoDeTarefas.Domain.Interfaces;
using GestaoDeTarefas.Infrastructure.Data;
using GestaoDeTarefas.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoDeTarefas.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase("GestaoDeTarefasDb"));

        services.AddScoped<ITarefaRepository, TarefaRepository>();

        return services;
    }
}