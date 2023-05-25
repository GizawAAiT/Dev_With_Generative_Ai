
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TaskApp.Domain;

namespace TaskApp.Persistence.Configurations.Entities
{
    public class TasksConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasData(
       new TaskEntity
       {
           Id = 1,
           Title = "Test",
           OwnerId = 5,
           Description = "Test",
           StartDate = new DateTime(2022, 1, 1),
           EndDate = new DateTime(2022, 1, 10)
       },

       new TaskEntity
       {
           Id = 2,
           Title = "Test 2",
           OwnerId = 7,
           Description = "Test 2",
           StartDate = new DateTime(2022, 1, 1), 
           EndDate = new DateTime(2022, 1, 10)
       }
   );
        }


    }
}