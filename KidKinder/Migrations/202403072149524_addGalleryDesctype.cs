namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGalleryDesctype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Galleries", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Galleries", "Description", c => c.Int(nullable: false));
        }
    }
}
