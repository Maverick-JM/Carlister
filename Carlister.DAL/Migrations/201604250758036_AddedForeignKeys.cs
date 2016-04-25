namespace Carlister.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKeys : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Enquiries", "CarID");
            AddForeignKey("dbo.Enquiries", "CarID", "dbo.Cars", "CarID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enquiries", "CarID", "dbo.Cars");
            DropIndex("dbo.Enquiries", new[] { "CarID" });
        }
    }
}
