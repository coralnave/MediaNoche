using Microsoft.AspNet.Identity.EntityFramework;
using MediaNoche.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MediaNoche.DAL
{
    public class MediaNocheContext : IdentityDbContext<ApplicationUser>
    {

        
        public MediaNocheContext() : base("MediaNocheContext")
        {
        }

        public DbSet<Active> Actives { get; set; }
        public DbSet<Excersize> Excersizes { get; set; }
        public DbSet<EveningLesson> EveningLessons { get; set; }
        public DbSet<Evening> Evenings { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }
    }
}