namespace MediaNoche.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix222 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.News", newName: "New");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.New", newName: "News");
        }
    }
}
