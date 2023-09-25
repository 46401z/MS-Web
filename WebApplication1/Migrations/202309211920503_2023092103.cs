namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2023092103 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.News");
            AlterColumn("dbo.News", "Id", c => c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"));
            AddPrimaryKey("dbo.News", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.News");
            AlterColumn("dbo.News", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.News", "Id");
        }
    }
}
