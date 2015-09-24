//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace MediaNoche.DAL
//{
//    public class MediaNocheContext
//    {
//    }
//}

using MediaNoche.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MediaNoche.DAL
{
    public class MediaNocheContext : DbContext
    {

        public MediaNocheContext() : base("MediaNocheContext")
        {
        }

        public DbSet<Active> Actives { get; set; }
        public DbSet<Excersize> Excersizes { get; set; }
        public DbSet<EveningClass> EveningClasses { get; set; }
        public DbSet<Evening> Evenings { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}