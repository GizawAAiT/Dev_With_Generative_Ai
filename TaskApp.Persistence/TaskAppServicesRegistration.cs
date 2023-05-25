using TaskApp.Application.Contracts.Persistence;
using TaskApp.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace TaskApp.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TaskAppDbContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("TaskAppConnectionString")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            return services;
        }
    }
}
