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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            var project1 = new Project
            {
               Id = new Guid("2a5550ea-a0fd-4859-b483-9e0fd7489adb"),
               Name = "Project 1" 
            };

            var project2 = new Project
            {
                Id = new Guid("3a5550ea-a0fd-4859-b483-9e0fd7489adb"),
                Name = "Project 2"
            };

            builder.HasData(project1,project2);
        }
    }
}
