namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial31 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Marks", "Detail_Id", "dbo.Details");
            DropIndex("dbo.Marks", new[] { "Detail_Id" });
            CreateIndex("dbo.Details", "MarkId");
            AddForeignKey("dbo.Details", "MarkId", "dbo.Marks", "Id");
            DropColumn("dbo.Marks", "Detail_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Marks", "Detail_Id", c => c.Int());
            DropForeignKey("dbo.Details", "MarkId", "dbo.Marks");
            DropIndex("dbo.Details", new[] { "MarkId" });
            CreateIndex("dbo.Marks", "Detail_Id");
            AddForeignKey("dbo.Marks", "Detail_Id", "dbo.Details", "Id");
        }
    }
}
