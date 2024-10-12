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
    public class TypeLeavesConfiguration : IEntityTypeConfiguration<TypeLeaves>
    {
        public void Configure(EntityTypeBuilder<TypeLeaves> builder)
        {
            var casual = new TypeLeaves
            {
                Id = new Guid("1e3258cb-a0fd-4859-b483-9e0fd7489adb"),
                Name = "Casual"
            };


            builder.HasData(casual);
        }
    }
}
