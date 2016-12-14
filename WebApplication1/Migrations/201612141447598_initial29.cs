namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial29 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarkType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "IdMark", c => c.Int());
            CreateIndex("dbo.Cars", "IdMark");
            AddForeignKey("dbo.Cars", "IdMark", "dbo.Marks", "Id");
            DropColumn("dbo.Cars", "Mark");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "Mark", c => c.String());
            DropForeignKey("dbo.Cars", "IdMark", "dbo.Marks");
            DropIndex("dbo.Cars", new[] { "IdMark" });
            DropColumn("dbo.Cars", "IdMark");
            DropTable("dbo.Marks");
        }
    }
}
