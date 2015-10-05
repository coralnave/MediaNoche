namespace MediaNoche.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Active",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirsName = c.String(),
                        LastName = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Availability = c.Boolean(nullable: false),
                        Picture = c.String(),
                        Summary = c.String(),
                        EveningLesson_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EveningLesson", t => t.EveningLesson_ID)
                .Index(t => t.EveningLesson_ID);
            
            CreateTable(
                "dbo.EveningLesson",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ActiveID = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                        LessonNum = c.Int(nullable: false),
                        Evening_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Evening", t => t.Evening_ID)
                .Index(t => t.Evening_ID);
            
            CreateTable(
                "dbo.Excersize",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Video = c.String(),
                        EveningLesson_ID = c.Int(),
                        Lesson_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EveningLesson", t => t.EveningLesson_ID)
                .ForeignKey("dbo.Lesson", t => t.Lesson_ID)
                .Index(t => t.EveningLesson_ID)
                .Index(t => t.Lesson_ID);
            
            CreateTable(
                "dbo.Evening",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EveningLessonID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Concept = c.String(),
                        Announcer_ID = c.Int(),
                        DJ_ID = c.Int(),
                        EveningManager_ID = c.Int(),
                        EveningManagerAssistant_ID = c.Int(),
                        IntroductoryRateGuide_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Active", t => t.Announcer_ID)
                .ForeignKey("dbo.Active", t => t.DJ_ID)
                .ForeignKey("dbo.Active", t => t.EveningManager_ID)
                .ForeignKey("dbo.Active", t => t.EveningManagerAssistant_ID)
                .ForeignKey("dbo.Active", t => t.IntroductoryRateGuide_ID)
                .Index(t => t.Announcer_ID)
                .Index(t => t.DJ_ID)
                .Index(t => t.EveningManager_ID)
                .Index(t => t.EveningManagerAssistant_ID)
                .Index(t => t.IntroductoryRateGuide_ID);
            
            CreateTable(
                "dbo.Lesson",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Level = c.Int(nullable: false),
                        LessonNum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Excersize", "Lesson_ID", "dbo.Lesson");
            DropForeignKey("dbo.Evening", "IntroductoryRateGuide_ID", "dbo.Active");
            DropForeignKey("dbo.Evening", "EveningManagerAssistant_ID", "dbo.Active");
            DropForeignKey("dbo.Evening", "EveningManager_ID", "dbo.Active");
            DropForeignKey("dbo.EveningLesson", "Evening_ID", "dbo.Evening");
            DropForeignKey("dbo.Evening", "DJ_ID", "dbo.Active");
            DropForeignKey("dbo.Evening", "Announcer_ID", "dbo.Active");
            DropForeignKey("dbo.Excersize", "EveningLesson_ID", "dbo.EveningLesson");
            DropForeignKey("dbo.Active", "EveningLesson_ID", "dbo.EveningLesson");
            DropIndex("dbo.Evening", new[] { "IntroductoryRateGuide_ID" });
            DropIndex("dbo.Evening", new[] { "EveningManagerAssistant_ID" });
            DropIndex("dbo.Evening", new[] { "EveningManager_ID" });
            DropIndex("dbo.Evening", new[] { "DJ_ID" });
            DropIndex("dbo.Evening", new[] { "Announcer_ID" });
            DropIndex("dbo.Excersize", new[] { "Lesson_ID" });
            DropIndex("dbo.Excersize", new[] { "EveningLesson_ID" });
            DropIndex("dbo.EveningLesson", new[] { "Evening_ID" });
            DropIndex("dbo.Active", new[] { "EveningLesson_ID" });
            DropTable("dbo.Lesson");
            DropTable("dbo.Evening");
            DropTable("dbo.Excersize");
            DropTable("dbo.EveningLesson");
            DropTable("dbo.Active");
        }
    }
}
