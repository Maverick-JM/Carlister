using System.Data.Entity;
using System.Linq;
using Carlister.Common.DTO;
using Carlister.Common.Data;

namespace Carlister.DAL
{
    public class CarlisterEntities : DbContext, ICarlisterDataSource
    {
        // Your context has been configured to use a 'CarlisterEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Carlister.DAL.CarlisterEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CarlisterEntities' 
        // connection string in the application configuration file.
        public CarlisterEntities()
            : base("name=CarlisterEntities")
        {
        }

        public IDbSet<Car> Cars { get; set; }
        public IDbSet<Enquiry> Enquiries { get; set; }

        public IQueryable<ICar> GetCars()
        {
            return this.Cars;
        }

        public IQueryable<IEnquiry> GetEnquiries()
        {
            return this.Enquiries;
        }

        public ICar GetCar(int carID)
        {
            return this.Cars.FirstOrDefault(c => c.CarID == carID);
        }

        public IEnquiry GetEnquiry(int enquiryID)
        {
            return this.Enquiries.FirstOrDefault(e => e.EnquiryID == enquiryID);
        }

        public ICar Add(ICar car)
        {
            return this.Cars.Add(new Car()
            {
                Comments = car.Comments,
                ContactName = car.ContactName,
                DapPrice = car.DapPrice,
                DealerABN = car.DealerABN,
                EgcPrice = car.EgcPrice,
                Email = car.Email,
                Make = car.Make,
                Model = car.Model,
                Phone = car.Phone,
                PriceType = car.PriceType,
                SaleType = car.SaleType,
                Year = car.Year
            });
        }

        public IEnquiry Add(IEnquiry enquiry)
        {
            // We don't care about the incoming enquiryId, we're just going to ignore it
            return this.Enquiries.Add(new Enquiry()
            {
                CarID = enquiry.CarID,
                Email = enquiry.Email,
                Name = enquiry.Name
            });
        }
    }
}
