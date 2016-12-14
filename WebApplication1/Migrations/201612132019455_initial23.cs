namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial23 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Washes", "Number", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Washes", "Number", c => c.Int(nullable: false));
        }
    }
}
