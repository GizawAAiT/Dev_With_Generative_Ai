using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace TaskApp.Persistence
{
    public class TaskAppDbContextFactory : IDesignTimeDbContextFactory<TaskAppDbContext>
    {
        public TaskAppDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory() + "/../TaskApp.API")
                 .AddJsonFile("appsettings.json")
                 .Build();

            var builder = new DbContextOptionsBuilder<TaskAppDbContext>();
            var connectionString = configuration.GetConnectionString("TaskAppConnectionString");

            builder.UseNpgsql(connectionString);

            return new TaskAppDbContext(builder.Options);
        }
    }
}
