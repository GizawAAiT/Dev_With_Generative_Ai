
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TaskApp.Domain;

namespace TaskApp.Persistence.Configurations.Entities
{
    public class ChecklistConfiguration : IEntityTypeConfiguration<Checklist>
    {
        public void Configure(EntityTypeBuilder<Checklist> builder)
        {
            builder.HasData(
                new Checklist
                {
                    Id = 1,
                    Title = "Test",
                     Description = "Test",
                     TaskId = 2,
                },

                 new Checklist
                 {
                     Id = 2,
                     Title = "Test 2",
                     Description = "Test 2",
                     TaskId = 2,
                 }
                ); 
        }

    }
}