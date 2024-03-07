namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGalleryStatu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Galleries", "Statu", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Galleries", "Statu");
        }
    }
}
