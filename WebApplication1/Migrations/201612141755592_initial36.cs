namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial36 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "GearBox", c => c.String());
            AddColumn("dbo.Cars", "Volume", c => c.String());
            AddColumn("dbo.Cars", "Transmission", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Transmission");
            DropColumn("dbo.Cars", "Volume");
            DropColumn("dbo.Cars", "GearBox");
        }
    }
}
