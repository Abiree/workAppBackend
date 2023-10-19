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
    public class LeaveConfiguration : IEntityTypeConfiguration<Leaves>
    {
        public void Configure(EntityTypeBuilder<Leaves> builder)
        {
            var leave1 = new Leaves
            {
                Id = new Guid("1e8356cb-a0fd-4859-e780-9e0fd7489afb"),
                UserId = new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489afb").ToString(),
                TypeId = new Guid("1e3258cb-a0fd-4859-b483-9e0fd7489adb"),
                Fromdate = DateTime.SpecifyKind(DateTime.Parse("2022-11-06"), DateTimeKind.Utc),
                Todate = DateTime.SpecifyKind(DateTime.Parse("2022-11-08"), DateTimeKind.Utc),
                Days = 3,
                StatutId = new Guid("1a5550ea-a0fd-4859-b483-9e0fd7489adb"),
                Desc = "Friend's Wedding Celebration"

            };

            var leave2 = new Leaves
            {
                Id = new Guid("1e8356de-a0fd-4859-e780-9e0fd7489afb"),
                UserId = new Guid("1e8356cb-a0fd-3619-b483-9e0fd7489aaa").ToString(),
                TypeId = new Guid("1e3258cb-a0fd-4859-b483-9e0fd7489adb"),
                Fromdate = DateTime.SpecifyKind(DateTime.Parse("2022-11-16"), DateTimeKind.Utc),
                Todate = DateTime.SpecifyKind(DateTime.Parse("2022-11-20"), DateTimeKind.Utc),
                Days = 5,
                StatutId = new Guid("1a5550ea-a0fd-4859-b483-9e0fd7489adb"),
                Desc = "Vacation"

            };

            builder.HasData(leave1,leave2);
        }
    }
}
