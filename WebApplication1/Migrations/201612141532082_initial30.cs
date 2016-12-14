namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial30 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "Detail_Id", "dbo.Details");
            DropIndex("dbo.Cars", new[] { "Detail_Id" });
            AddColumn("dbo.Marks", "Detail_Id", c => c.Int());
            AddColumn("dbo.Details", "MarkId", c => c.Int());
            CreateIndex("dbo.Marks", "Detail_Id");
            AddForeignKey("dbo.Marks", "Detail_Id", "dbo.Details", "Id");
            DropColumn("dbo.Cars", "Detail_Id");
            DropColumn("dbo.Details", "CarId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Details", "CarId", c => c.Int());
            AddColumn("dbo.Cars", "Detail_Id", c => c.Int());
            DropForeignKey("dbo.Marks", "Detail_Id", "dbo.Details");
            DropIndex("dbo.Marks", new[] { "Detail_Id" });
            DropColumn("dbo.Details", "MarkId");
            DropColumn("dbo.Marks", "Detail_Id");
            CreateIndex("dbo.Cars", "Detail_Id");
            AddForeignKey("dbo.Cars", "Detail_Id", "dbo.Details", "Id");
        }
    }
}
