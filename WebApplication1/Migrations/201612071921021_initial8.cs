namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial8 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Recalls");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Recalls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Recalls = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
