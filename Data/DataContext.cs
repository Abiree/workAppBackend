using Data.Configuration;
using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Task = Entities.Entities.Task;

namespace Data
{
    public class DataContext : IdentityDbContext<User>
    {

        public DbSet<Designation> Designations { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Leaves> Leaves { get; set; }
        public DbSet<Statut> Statuts { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TypeLeaves> TypeLeaves { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected DataContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);

            // Configure the primary key for IdentityUserLogin
            builder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.HasKey(l => new { l.LoginProvider, l.ProviderKey });
            });


            builder.Entity<TaskTag>()
                .HasKey(tt => new { tt.TaskId, tt.TagId });

            builder.Entity<TaskTag>()
                .HasOne(tt => tt.Task)
                .WithMany(t => t.TaskTags)
                .HasForeignKey(tt => tt.TaskId);

            builder.Entity<TaskTag>()
                .HasOne(tt => tt.Tag)
                .WithMany(t => t.TaskTags)
                .HasForeignKey(tt => tt.TagId);

            //seeding data
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new TypeLeavesConfiguration());
            builder.ApplyConfiguration(new ProjectConfiguration());
            builder.ApplyConfiguration(new StatutConfiguration());
            builder.ApplyConfiguration(new DesignationConfiguration());
            builder.ApplyConfiguration(new TeamConfiguration());
            builder.ApplyConfiguration(new ActivityConfiguration());
            builder.ApplyConfiguration(new LeaveConfiguration());
            builder.ApplyConfiguration(new TaskConfiguration());
            builder.ApplyConfiguration(new TagConfiguration());
            builder.ApplyConfiguration(new TaskTagConfiguration());
        }
    }
}