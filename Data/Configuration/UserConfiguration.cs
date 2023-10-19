using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var email_admin = "abireghallabii@gmail.com";
            var username_admin = "abire";

            var email1 = "henry@gmail.com";
            var username1 = "henry";

            var email2 = "jenny@gmail.com";
            var username2 = "jenny";

            var adminUser = new User
            {
                Id = new Guid("1e2226cb-a0fd-4859-b483-9e0fd7489afb").ToString(),
                UserName = username_admin,
                NormalizedUserName = username_admin.Trim().ToUpper(),
                Email = email_admin,
                NormalizedEmail = email_admin.Trim().ToUpper(),
                FirstName = "Abire",
                LastName = "Ghallabi",
                DateBirth = DateTime.SpecifyKind(DateTime.Parse("1999-06-03 14:30:00"), DateTimeKind.Utc),
                StartDay = DateTime.SpecifyKind(DateTime.Parse("2022-09-05 08:30:00"), DateTimeKind.Utc),
                DesignationId = new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb"),
                TeamId =  new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb")


            };


            var emplopeUser = new User
            {
                Id = new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489afb").ToString(),
                UserName = username1,
                NormalizedUserName = username1.Trim().ToUpper(),
                Email = email1,
                NormalizedEmail = email1.Trim().ToUpper(),
                FirstName = "Courtney",
                LastName = "Henry",
                DateBirth = DateTime.SpecifyKind(DateTime.Parse("1999-03-13 14:30:00"), DateTimeKind.Utc),
                StartDay = DateTime.SpecifyKind(DateTime.Parse("2022-09-15 08:30:00"), DateTimeKind.Utc),
                DesignationId = new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb"),
                TeamId = new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb")

            };

            var emplopeUser2 = new User
            {
                Id = new Guid("1e8356cb-a0fd-3619-b483-9e0fd7489aaa").ToString(),
                UserName = username2,
                NormalizedUserName = username2.Trim().ToUpper(),
                Email = email2,
                NormalizedEmail = email2.Trim().ToUpper(),
                FirstName = "Jenny",
                LastName = "Wilson",
                DateBirth = DateTime.SpecifyKind(DateTime.Parse("1999-01-03 14:30:00"), DateTimeKind.Utc),
                StartDay = DateTime.SpecifyKind(DateTime.Parse("2022-02-05 08:30:00"), DateTimeKind.Utc),
                DesignationId = new Guid("1e8356cb-a0fd-4859-b253-9e0fd7489adb"),
                TeamId = new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb"),
                ManagerId = new Guid("1e2226cb-a0fd-4859-b483-9e0fd7489afb").ToString()

            };

            var passwordHasher = new PasswordHasher<User>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Azerty123@@@");
            emplopeUser.PasswordHash = passwordHasher.HashPassword(emplopeUser, "Azerty123@@@");
            

            builder.HasData(adminUser,emplopeUser, emplopeUser2);
        }
    }
}
