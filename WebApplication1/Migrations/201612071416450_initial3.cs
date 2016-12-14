namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Number", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "Mark", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Mark");
            DropColumn("dbo.Cars", "Number");
        }
    }
}
