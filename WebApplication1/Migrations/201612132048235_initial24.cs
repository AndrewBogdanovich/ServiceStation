namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial24 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Details", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Details", "Image");
        }
    }
}
