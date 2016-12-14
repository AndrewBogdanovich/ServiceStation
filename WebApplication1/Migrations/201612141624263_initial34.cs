namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial34 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "GearBox_Id", "dbo.GearBoxes");
            DropIndex("dbo.Cars", new[] { "GearBox_Id" });
            AddColumn("dbo.Cars", "GearBox", c => c.String());
            DropColumn("dbo.Cars", "IdGearBox");
            DropColumn("dbo.Cars", "GearBox_Id");
            DropTable("dbo.GearBoxes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GearBoxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Gearbox = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "GearBox_Id", c => c.Int());
            AddColumn("dbo.Cars", "IdGearBox", c => c.Int());
            DropColumn("dbo.Cars", "GearBox");
            CreateIndex("dbo.Cars", "GearBox_Id");
            AddForeignKey("dbo.Cars", "GearBox_Id", "dbo.GearBoxes", "Id");
        }
    }
}
