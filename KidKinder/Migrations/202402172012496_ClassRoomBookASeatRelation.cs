namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassRoomBookASeatRelation : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.BookASeats", "ClassRoomId");
            AddForeignKey("dbo.BookASeats", "ClassRoomId", "dbo.ClassRooms", "ClassRoomId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookASeats", "ClassRoomId", "dbo.ClassRooms");
            DropIndex("dbo.BookASeats", new[] { "ClassRoomId" });
        }
    }
}
