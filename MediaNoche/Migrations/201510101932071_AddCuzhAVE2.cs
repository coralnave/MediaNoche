namespace MediaNoche.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCuzhAVE2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Active", "LastName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Active", "Summary", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Active", "Summary", c => c.String(nullable: false));
            AlterColumn("dbo.Active", "LastName", c => c.String(nullable: false));
        }
    }
}
