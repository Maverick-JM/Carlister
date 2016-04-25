using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carlister.Common.DTO;
using Carlister.Common.Data;
using Carlister.Common.Enums;

namespace Carlister.BLL.Cars
{
    public class Car
    {
        public int CarID { get; set; }
        public SaleType SaleType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int PriceType { get; set; }
        public decimal? EgcPrice { get; set; }
        public decimal? DapPrice { get; set; }
        public string Email { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string DealerABN { get; set; }
        public string Comments { get; set; }

        public Car()
        {

        }

        internal Car(ICar carData)
        {
            CarID = carData.CarID;
            SaleType = carData.SaleType;
            Make = carData.Make;
            Model = carData.Model;
            Year = carData.Year;
            PriceType = carData.PriceType;
            EgcPrice = carData.EgcPrice;
            DapPrice = carData.DapPrice;
            Email = carData.Email;
            ContactName = carData.ContactName;
            Phone = carData.Phone;
            DealerABN = carData.DealerABN;
            Comments = carData.Comments;
        }

        public static List<Car> GetCars(ICarDataSource db)
        {
            return db.GetCars()
                .ToList()   // Fetch from DB
                .Select(c => CarFactory.CreateCar(c))
                .ToList();
        }

        public static Car GetCar(int carId, ICarDataSource db)
        {
            var carData = db.GetCar(carId);
            return CarFactory.CreateCar(carData);
        }
    }
}
