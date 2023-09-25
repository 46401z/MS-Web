namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2023092102 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "DateTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "DateTime", c => c.DateTime(nullable: false));
        }
    }
}
