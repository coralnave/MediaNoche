﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaNoche
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MediaNocheContextEntities : DbContext
    {
        public MediaNocheContextEntities()
            : base("name=MediaNocheContextEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Active> Actives { get; set; }
        public virtual DbSet<Evening> Evenings { get; set; }
        public virtual DbSet<EveningLesson> EveningLessons { get; set; }
        public virtual DbSet<Excersize> Excersizes { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
    }
}
