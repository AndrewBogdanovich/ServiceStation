namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial28 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CarId = c.Int(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "Detail_Id", c => c.Int());
            CreateIndex("dbo.Cars", "Detail_Id");
            AddForeignKey("dbo.Cars", "Detail_Id", "dbo.Details", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "Detail_Id", "dbo.Details");
            DropIndex("dbo.Cars", new[] { "Detail_Id" });
            DropColumn("dbo.Cars", "Detail_Id");
            DropTable("dbo.Details");
        }
    }
}
