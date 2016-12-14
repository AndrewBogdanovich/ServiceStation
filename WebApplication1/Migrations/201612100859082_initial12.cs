namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Cars", "User_Id");
            AddForeignKey("dbo.Cars", "User_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Cars", "Name");
            DropColumn("dbo.Cars", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "Number", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "Name", c => c.String());
            DropForeignKey("dbo.Cars", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Cars", new[] { "User_Id" });
            DropColumn("dbo.Cars", "User_Id");
        }
    }
}
