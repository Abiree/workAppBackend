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
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            var team1 = new Team
            {
                Id = new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb"),
                Name = "Team 1"
            };

            var team2 = new Team
            {
                Id = new Guid("1e8356cb-a0fd-3256-b483-9e0fd7489adb"),
                Name = "Team 2"
            };


            builder.HasData(team1,team2);

        }
    }
}
