namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial10 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderCars", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.OrderCars", "Car_Id", "dbo.Cars");
            DropIndex("dbo.OrderCars", new[] { "Order_Id" });
            DropIndex("dbo.OrderCars", new[] { "Car_Id" });
            AddColumn("dbo.Orders", "Car_Id", c => c.Int());
            CreateIndex("dbo.Orders", "Car_Id");
            AddForeignKey("dbo.Orders", "Car_Id", "dbo.Cars", "Id");
            DropTable("dbo.OrderCars");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrderCars",
                c => new
                    {
                        Order_Id = c.Int(nullable: false),
                        Car_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Order_Id, t.Car_Id });
            
            DropForeignKey("dbo.Orders", "Car_Id", "dbo.Cars");
            DropIndex("dbo.Orders", new[] { "Car_Id" });
            DropColumn("dbo.Orders", "Car_Id");
            CreateIndex("dbo.OrderCars", "Car_Id");
            CreateIndex("dbo.OrderCars", "Order_Id");
            AddForeignKey("dbo.OrderCars", "Car_Id", "dbo.Cars", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderCars", "Order_Id", "dbo.Orders", "Id", cascadeDelete: true);
        }
    }
}
