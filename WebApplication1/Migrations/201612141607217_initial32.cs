namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial32 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GearBoxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Gearbox = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "Volume", c => c.String());
            AddColumn("dbo.Cars", "IdGearBox", c => c.Int());
            AddColumn("dbo.Cars", "GearBox_Id", c => c.Int());
            CreateIndex("dbo.Cars", "GearBox_Id");
            AddForeignKey("dbo.Cars", "GearBox_Id", "dbo.GearBoxes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "GearBox_Id", "dbo.GearBoxes");
            DropIndex("dbo.Cars", new[] { "GearBox_Id" });
            DropColumn("dbo.Cars", "GearBox_Id");
            DropColumn("dbo.Cars", "IdGearBox");
            DropColumn("dbo.Cars", "Volume");
            DropTable("dbo.GearBoxes");
        }
    }
}
