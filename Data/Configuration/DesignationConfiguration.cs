using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class DesignationConfiguration : IEntityTypeConfiguration<Designation>
    {
        public void Configure(EntityTypeBuilder<Designation> builder)
        {
            var designation1 = new Designation
            {
                Id = new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb"),
                Name = "Software Engineer"
            };

            var designation2 = new Designation
            {
                Id = new Guid("1e8356cb-a0fd-4859-b253-9e0fd7489adb"),
                Name = "UI/UX designer"
            };

            builder.HasData(designation1, designation2);
        }
    }
}
