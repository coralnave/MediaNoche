namespace MediaNoche.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IhaveTo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Active", "FirsName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Active", "FirsName", c => c.String(nullable: false));
        }
    }
}
