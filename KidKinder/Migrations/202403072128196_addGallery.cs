namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGallery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Description = c.Int(nullable: false),
                        Image1 = c.String(),
                        Image2 = c.String(),
                    })
                .PrimaryKey(t => t.GalleryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Galleries");
        }
    }
}
