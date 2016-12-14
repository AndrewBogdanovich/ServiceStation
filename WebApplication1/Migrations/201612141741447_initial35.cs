namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial35 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cars", "Volume");
            DropColumn("dbo.Cars", "GearBox");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "GearBox", c => c.String());
            AddColumn("dbo.Cars", "Volume", c => c.String());
        }
    }
}
