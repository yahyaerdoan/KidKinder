namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBranch : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BranchId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Branches");
        }
    }
}
