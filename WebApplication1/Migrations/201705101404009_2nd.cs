namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2nd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Url", c => c.String());
            AddColumn("dbo.Movies", "Genre", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Year", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Director", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Director");
            DropColumn("dbo.Movies", "Year");
            DropColumn("dbo.Movies", "Genre");
            DropColumn("dbo.Movies", "Url");
        }
    }
}
