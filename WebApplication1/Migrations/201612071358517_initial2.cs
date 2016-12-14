namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cars", "cigane");
            DropTable("dbo.Pidorasovs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Pidorasovs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        bahargovno = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "cigane", c => c.String());
        }
    }
}
