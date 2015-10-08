namespace MediaNoche.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Evening", "Announcer_ID", "dbo.Active");
            DropForeignKey("dbo.Evening", "DJ_ID", "dbo.Active");
            DropForeignKey("dbo.Evening", "EveningManager_ID", "dbo.Active");
            DropForeignKey("dbo.Evening", "EveningManagerAssistant_ID", "dbo.Active");
            DropForeignKey("dbo.Evening", "IntroductoryRateGuide_ID", "dbo.Active");
            DropIndex("dbo.Evening", new[] { "Announcer_ID" });
            DropIndex("dbo.Evening", new[] { "DJ_ID" });
            DropIndex("dbo.Evening", new[] { "EveningManager_ID" });
            DropIndex("dbo.Evening", new[] { "EveningManagerAssistant_ID" });
            DropIndex("dbo.Evening", new[] { "IntroductoryRateGuide_ID" });
            AlterColumn("dbo.Evening", "Announcer_ID", c => c.Int());
            AlterColumn("dbo.Evening", "DJ_ID", c => c.Int());
            AlterColumn("dbo.Evening", "EveningManager_ID", c => c.Int());
            AlterColumn("dbo.Evening", "EveningManagerAssistant_ID", c => c.Int());
            AlterColumn("dbo.Evening", "IntroductoryRateGuide_ID", c => c.Int());
            CreateIndex("dbo.Evening", "Announcer_ID");
            CreateIndex("dbo.Evening", "DJ_ID");
            CreateIndex("dbo.Evening", "EveningManager_ID");
            CreateIndex("dbo.Evening", "EveningManagerAssistant_ID");
            CreateIndex("dbo.Evening", "IntroductoryRateGuide_ID");
            AddForeignKey("dbo.Evening", "Announcer_ID", "dbo.Active", "ID");
            AddForeignKey("dbo.Evening", "DJ_ID", "dbo.Active", "ID");
            AddForeignKey("dbo.Evening", "EveningManager_ID", "dbo.Active", "ID");
            AddForeignKey("dbo.Evening", "EveningManagerAssistant_ID", "dbo.Active", "ID");
            AddForeignKey("dbo.Evening", "IntroductoryRateGuide_ID", "dbo.Active", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Evening", "IntroductoryRateGuide_ID", "dbo.Active");
            DropForeignKey("dbo.Evening", "EveningManagerAssistant_ID", "dbo.Active");
            DropForeignKey("dbo.Evening", "EveningManager_ID", "dbo.Active");
            DropForeignKey("dbo.Evening", "DJ_ID", "dbo.Active");
            DropForeignKey("dbo.Evening", "Announcer_ID", "dbo.Active");
            DropIndex("dbo.Evening", new[] { "IntroductoryRateGuide_ID" });
            DropIndex("dbo.Evening", new[] { "EveningManagerAssistant_ID" });
            DropIndex("dbo.Evening", new[] { "EveningManager_ID" });
            DropIndex("dbo.Evening", new[] { "DJ_ID" });
            DropIndex("dbo.Evening", new[] { "Announcer_ID" });
            AlterColumn("dbo.Evening", "IntroductoryRateGuide_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Evening", "EveningManagerAssistant_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Evening", "EveningManager_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Evening", "DJ_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Evening", "Announcer_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Evening", "IntroductoryRateGuide_ID");
            CreateIndex("dbo.Evening", "EveningManagerAssistant_ID");
            CreateIndex("dbo.Evening", "EveningManager_ID");
            CreateIndex("dbo.Evening", "DJ_ID");
            CreateIndex("dbo.Evening", "Announcer_ID");
            AddForeignKey("dbo.Evening", "IntroductoryRateGuide_ID", "dbo.Active", "ID", cascadeDelete: false);
            AddForeignKey("dbo.Evening", "EveningManagerAssistant_ID", "dbo.Active", "ID", cascadeDelete: false);
            AddForeignKey("dbo.Evening", "EveningManager_ID", "dbo.Active", "ID", cascadeDelete: false);
            AddForeignKey("dbo.Evening", "DJ_ID", "dbo.Active", "ID", cascadeDelete: false);
            AddForeignKey("dbo.Evening", "Announcer_ID", "dbo.Active", "ID", cascadeDelete: false);
        }
    }
}
