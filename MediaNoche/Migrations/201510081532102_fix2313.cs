namespace MediaNoche.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix2313 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Location", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.New", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.New", "Title", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Location", "Title", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
