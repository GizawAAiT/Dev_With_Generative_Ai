

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
       new Task
       {
           Id = 1,
           Title = "Test",
           OwnerId = "fb8656da-2b94-474f-8709-85e0cd7ea903",
           Description = "Test",
           StartDate = new DateTime(2022, 1, 1),
           EndDate = new DateTime(2022, 1, 10)
       },

       new Task
       {
           Id = 2,
           Title = "Test 2",
           OwnerId = "e6c52d57-24b6-4524-be10-eb7bce4d3217",
           Description = "Test 2",
           StartDate = new DateTime(2022, 1, 1),
           EndDate = new DateTime(2022, 1, 10)
       }
   );
        }


    }
}