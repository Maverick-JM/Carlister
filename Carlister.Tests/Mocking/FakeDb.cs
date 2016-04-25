using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carlister.Common.DTO;

namespace Carlister.Tests.Mocking
{
    public class FakeDb : Carlister.Common.Data.ICarlisterDataSource
    {
        List<Car> Cars { get; set; }
        List<Enquiry> Enquiries { get; set; }

        public FakeDb()
        {
            this.Cars = new List<Car>();
            this.Enquiries = new List<Enquiry>();
        }

        public FakeDb(List<Car> cars)
        {
            this.Cars = cars;
            this.Enquiries = new List<Enquiry>();
        }

        public FakeDb(List<Enquiry> enquiries)
        {
            this.Cars = new List<Car>();
            this.Enquiries = enquiries;
        }

        public FakeDb(List<Car> cars, List<Enquiry> enquiries)
        {
            this.Cars = cars;
            this.Enquiries = enquiries;
        }

        public IEnquiry Add(IEnquiry obj)
        {
            this.Enquiries.Add(new Enquiry()
            {

            });
            return obj;
        }

        public ICar Add(ICar obj)
        {
            this.Cars.Add(new Car() {

            });
            return obj;
        }

        public void Dispose()
        {
            
        }

        public ICar GetCar(int carID)
        {
            return this.Cars.FirstOrDefault(c => c.CarID == carID);
        }

        public IQueryable<ICar> GetCars()
        {
            return this.Cars.AsQueryable();
        }

        public IQueryable<IEnquiry> GetEnquiries()
        {
            return this.Enquiries.AsQueryable();
        }

        public IEnquiry GetEnquiry(int enquiryID)
        {
            return this.Enquiries.FirstOrDefault(e => e.EnquiryID == enquiryID);
        }

        public int SaveChanges()
        {
            return 1;
        }
    }
}
