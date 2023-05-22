using TaskApp.Application.Contracts.Persistence;
using TaskApp.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
