using Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class TaskTagConfiguration : IEntityTypeConfiguration<TaskTag>
    {
        public void Configure(EntityTypeBuilder<TaskTag> builder)
        {
            var tasktag1 = new TaskTag
            {
                TagId = new Guid("1e4729ea-a0fd-4859-b483-9e0fd7422adb"),
                TaskId = new Guid("2a5680ea-a0fd-4859-b483-9e0fd7489adb")
            };

            var tasktag2 = new TaskTag
            {
                TagId = new Guid("1e2549ea-a0fd-4859-b483-9e0fd7433adb"),
                TaskId = new Guid("2a5680ea-a0fd-4859-b483-9e0fd7489adb")

            };

            builder.HasData(tasktag1, tasktag2);
        }



    }
}
