namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderCars",
                c => new
                    {
                        Order_Id = c.Int(nullable: false),
                        Car_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Order_Id, t.Car_Id })
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cars", t => t.Car_Id, cascadeDelete: true)
                .Index(t => t.Order_Id)
                .Index(t => t.Car_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderCars", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.OrderCars", "Order_Id", "dbo.Orders");
            DropIndex("dbo.OrderCars", new[] { "Car_Id" });
            DropIndex("dbo.OrderCars", new[] { "Order_Id" });
            DropTable("dbo.OrderCars");
            DropTable("dbo.Orders");
        }
    }
}
