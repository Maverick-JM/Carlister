namespace Carlister.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        SaleType = c.Int(nullable: false),
                        Make = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        PriceType = c.Int(nullable: false),
                        EgcPrice = c.Decimal(precision: 18, scale: 2),
                        DapPrice = c.Decimal(precision: 18, scale: 2),
                        Email = c.String(),
                        ContactName = c.String(),
                        Phone = c.String(),
                        DealerABN = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.CarID);
            
            CreateTable(
                "dbo.Enquiries",
                c => new
                    {
                        EnquiryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        CarID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnquiryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Enquiries");
            DropTable("dbo.Cars");
        }
    }
}
