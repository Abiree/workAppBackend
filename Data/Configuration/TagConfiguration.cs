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
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            var meeting = new Statut
            {
                Id = new Guid("1e4729ea-a0fd-4859-b483-9e0fd7422adb"),
                Name = "Meeting",
            };

            var uiDesign = new Statut
            {
                Id = new Guid("1e2549ea-a0fd-4859-b483-9e0fd7433adb"),
                Name = "UI Design"
            };

            builder.HasData(meeting,uiDesign);
        }



        }
    }
