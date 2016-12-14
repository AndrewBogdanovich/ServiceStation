namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial17 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "Car_Id", newName: "CarId");
            RenameIndex(table: "dbo.Orders", name: "IX_Car_Id", newName: "IX_CarId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Orders", name: "IX_CarId", newName: "IX_Car_Id");
            RenameColumn(table: "dbo.Orders", name: "CarId", newName: "Car_Id");
        }
    }
}
