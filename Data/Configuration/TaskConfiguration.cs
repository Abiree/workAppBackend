using Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Entities.Entities.Task;

namespace Data.Configuration
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            var task1 = new Task
            {
                Id = new Guid("2a5680ea-a0fd-4859-b483-9e0fd7489adb"),
                Name = "Task 1",
                Desc = "Description for Task 1",
                ProjectId = new Guid("2a5550ea-a0fd-4859-b483-9e0fd7489adb"), 
                CreationDate = DateTime.UtcNow,
                StartTime = DateTime.SpecifyKind(DateTime.Parse("2023-10-11T10:00:00"), DateTimeKind.Utc),
                EndTime = DateTime.SpecifyKind(DateTime.Parse("2023-10-11T15:00:00"), DateTimeKind.Utc)

            };

            builder.HasData(task1);

        }
    }
}
