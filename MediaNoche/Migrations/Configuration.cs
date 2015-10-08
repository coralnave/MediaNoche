namespace MediaNoche.Migrations
{
    using System;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MediaNoche.Models;
    using System.Collections.Generic;
    internal sealed class Configuration : DbMigrationsConfiguration<MediaNoche.DAL.MediaNocheContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MediaNoche.DAL.MediaNocheContext context)
        {   //-------------------------------------------------------
            if (!context.Roles.Any(r => r.Name == "Admins"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admins" };

                manager.Create(role);
            }
            //-------------------------------------------------------
            if (!context.Users.Any(u => u.UserName == "admin"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "admin" };

                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "Admins");
            }
            //-------------------------------------------------------
            List<Active> Actives = new List<Active>{
                new Active { FirsName = "Carson", LastName = "Alexander", Birthday = DateTime.Parse("2005-09-01"), Availability = true, Picture = "nop", Summary = "coral help" }
            };

            context.Actives.AddOrUpdate(
                p => p.ID,
                Actives[0]
            );

            //context.SaveChanges();


            //-------------------------------------------------------
            List<Excersize> Excersizes = new List<Excersize>{
                 new Excersize{Name="what what",Video="in the batt"}
             };

            context.Excersizes.AddOrUpdate(
                  p => p.ID,
                  Excersizes[0]
                  );
            //-------------------------------------------------------
            EveningLesson newEveninglesson = new EveningLesson { ActiveID = 1, Level = 1, LessonNum = 1, Actives = Actives, Excersizes = Excersizes };

            context.EveningLessons.AddOrUpdate(
                  p => p.ID,
                  newEveninglesson
            );

            //-------------------------------------------------------
            context.Evenings.AddOrUpdate(
                  p => p.ID,
                  new Evening
                  {
                      EveningLessonID = 1,
                      Date = DateTime.Parse("2005-09-01"),
                      Concept = "ch ch ch",
                      DJ = Actives[0],
                      Announcer = Actives[0],
                      EveningManager = Actives[0],
                      EveningManagerAssistant = Actives[0],
                      IntroductoryRateGuide = Actives[0]
                  }
            );

           //-------------------------------------------------------
            context.News.AddOrUpdate(
                 p => p.ID,
                 new New
                 {
                     Title = "חדשות האתר",
                     ShortInfo = "באתר. רק היום ועד אחריאת הימים",
                     UpdateForDate = DateTime.Parse("2015-10-15")
                 }
           );
           //-------------------------------------------------------
           context.Lessons.AddOrUpdate(
                   p => p.ID,
                   new Lesson
                   {
                       Level = 1,
                       LessonNum = 1,
                       Excersizes = Excersizes
                   }
           );
           //-------------------------------------------------------
           context.Locations.AddOrUpdate(
                   p => p.ID,
                   new Location
                   {
                       Title = "סניף קלקליה",
                       ShortInfo = "רומבה. צה צה וזריקת אבנים לרוחק",
                       Addres = "קלקילה"
                   }
           );

        }
    }
}

