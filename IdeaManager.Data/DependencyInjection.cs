using IdeaManager.Core.Interfaces;
using IdeaManager.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IdeaManager.Data;

public static class DependencyInjection
{
    public static IServiceCollection AddDataServices(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<IdeaDbContext>(options =>
            options.UseSqlite(connectionString));

        services.AddScoped<IIdeaRepository, IdeaRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
