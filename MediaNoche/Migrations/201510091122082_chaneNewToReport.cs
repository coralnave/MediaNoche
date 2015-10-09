namespace MediaNoche.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaneNewToReport : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.New", newName: "Report");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Report", newName: "New");
        }
    }
}
