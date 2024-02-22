namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTitle : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Teachers", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Title", c => c.String());
        }
    }
}
