namespace Carlister.DAL.Migrations
{
    using Common.Enums;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Carlister.DAL.CarlisterEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Carlister.DAL.CarlisterEntities context)
        {
            context.Cars.AddOrUpdate(p => p.CarID,
                new Car()
                {
                    CarID = 1,
                    Comments = "This is my car.",
                    ContactName = "John",
                    DapPrice = 16999,
                    DealerABN = null,
                    EgcPrice = null,
                    Email = "email@email.com",
                    Make = "Toyota",
                    Model = "Aurion",
                    Phone = "0417385451",
                    SaleType = SaleType.PrivateSale,
                    PriceType = 2,
                    Year = 2012
                },
                new Car()
                {
                    CarID = 2,
                    Comments = "There are many like it...",
                    DapPrice = 16999,
                    DealerABN = null,
                    EgcPrice = null,
                    Email = "email@email.com",
                    Make = "Toyota",
                    Model = "Aurion",
                    Phone = "0417385451",
                    SaleType = SaleType.PrivateSale,
                    PriceType = 2,
                    Year = 2012
                },
                new Car()
                {
                    CarID = 3,
                    Comments = "...but this one is mine.",
                    ContactName = "John",
                    DapPrice = 16999,
                    DealerABN = null,
                    EgcPrice = null,
                    Email = "email@email.com",
                    Make = "Toyota",
                    Model = "Aurion",
                    Phone = "0417385451",
                    SaleType = SaleType.PrivateSale,
                    PriceType = 2,
                    Year = 2012
                },
                new Car()
                {
                    CarID = 4,
                    Comments = "This is my car",
                    ContactName = "John",
                    DapPrice = 16999,
                    DealerABN = null,
                    EgcPrice = null,
                    Email = "email@email.com",
                    Make = "Toyota",
                    Model = "Aurion",
                    Phone = "0417385451",
                    SaleType = SaleType.PrivateSale,
                    PriceType = 2,
                    Year = 2012
                },
                new Car()
                {
                    CarID = 5,
                    Comments = "This is my car",
                    ContactName = "John",
                    DapPrice = 16999,
                    DealerABN = null,
                    EgcPrice = null,
                    Email = "email@email.com",
                    Make = "Toyota",
                    Model = "Aurion",
                    Phone = "0417385451",
                    SaleType = SaleType.PrivateSale,
                    PriceType = 2,
                    Year = 2012
                },
                new Car()
                {
                    CarID = 6,
                    Comments = "This is my car",
                    ContactName = "John",
                    DapPrice = 16999,
                    DealerABN = null,
                    EgcPrice = null,
                    Email = "email@email.com",
                    Make = "Toyota",
                    Model = "Aurion",
                    Phone = "0417385451",
                    SaleType = SaleType.PrivateSale,
                    PriceType = 2,
                    Year = 2012
                });

            context.SaveChanges();
        }
    }
}
