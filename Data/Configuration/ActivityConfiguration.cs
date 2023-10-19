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
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {

            var adminUserActivity = new Activity
            {
                Id = new Guid("1e3258cb-a9ae-4859-b483-9e0fd7489e13"),
                UserId = new Guid("1e2226cb-a0fd-4859-b483-9e0fd7489afb").ToString(),
                InTime = DateTime.UtcNow.Date.Add(TimeSpan.Parse("08:30:00")),
                OutTime = DateTime.UtcNow.Date.Add(TimeSpan.Parse("18:30:00")),
                WorkTime = new TimeSpan(9, 0, 0),
                BreakTime = new TimeSpan(1, 0, 0),
                OverTime = new TimeSpan(1, 0, 0),
                statutId = new Guid("1e4729ea-a0fd-4859-b483-9e0fd7489adb"),
                Date = DateTime.UtcNow

            };


            var emplopeUserActivity = new Activity
            {
                Id = new Guid("1e3258cb-a9ae-4859-b483-9e0fd7489adb"),
                UserId = new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489afb").ToString(),
                InTime = DateTime.UtcNow.Date.Add(TimeSpan.Parse("08:30:00")),
                OutTime = DateTime.UtcNow.Date.Add(TimeSpan.Parse("17:30:00")),
                WorkTime = new TimeSpan(8, 0, 0),
                BreakTime = new TimeSpan(1, 0,0),
                OverTime = new TimeSpan(0, 0,0),
                statutId = new Guid("1e4729ea-a0fd-4859-b483-9e0fd7489adb"),
                Date = DateTime.UtcNow

            };

            var emplopeUser2Activity = new Activity
            {
                Id = new Guid("1e3258cb-a9ae-4859-b483-9e0fd7489e15"),
                UserId = new Guid("1e8356cb-a0fd-3619-b483-9e0fd7489aaa").ToString(),
                InTime = DateTime.UtcNow.Date.Add(TimeSpan.Parse("08:30:00")),
                OutTime = DateTime.UtcNow.Date.Add(TimeSpan.Parse("19:30:00")),
                WorkTime = new TimeSpan(10, 0, 0),
                BreakTime = new TimeSpan(1, 0, 0),
                OverTime = new TimeSpan(2, 0, 0),
                statutId = new Guid("1e4729ea-a0fd-4859-b483-9e0fd7489adb"),
                Date = DateTime.UtcNow

            };



            builder.HasData(adminUserActivity,emplopeUserActivity,emplopeUser2Activity);
        }
    }
}
