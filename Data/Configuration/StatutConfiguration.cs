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
    public class StatutConfiguration : IEntityTypeConfiguration<Statut>
    {
        public void Configure(EntityTypeBuilder<Statut> builder)
        {
            var present = new Statut
            {
                Id = new Guid("1e4729ea-a0fd-4859-b483-9e0fd7489adb"),
                Name = "Present",
                Args = "activity"
            };

            var absent = new Statut
            {
                Id = new Guid("1e2549ea-a0fd-4859-b483-9e0fd7489adb"),
                Name = "Absent",
                Args = "activity"
            };


            var pending = new Statut
            {
                Id = new Guid("1a5550ea-a0fd-4859-b483-9e0fd7489adb"),
                Name = "Pending",
                Args = "leaves"
            };

            var approuved = new Statut
            {
                Id = new Guid("1a5551ea-a0fd-4859-b483-9e0fd7489adb"),
                Name = "Approuved",
                Args = "leaves"
            };

            var denied = new Statut
            {
                Id = new Guid("1a5553ea-a0fd-4859-b483-9e0fd7489adb"),
                Name = "Denied",
                Args = "leaves"
            };

            builder.HasData(present, absent, pending,approuved,denied);
        }         
     
    }
}
