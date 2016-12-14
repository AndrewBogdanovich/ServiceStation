namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Details", "Name", c => c.String());
            AddColumn("dbo.Details", "Type", c => c.String());
            AddColumn("dbo.Details", "Descriptions", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Details", "Descriptions");
            DropColumn("dbo.Details", "Type");
            DropColumn("dbo.Details", "Name");
        }
    }
}
