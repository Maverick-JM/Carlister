using Carlister.Web.ViewModels.Enquiries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlister.Web.ViewModels.Cars
{
    public class CarDetailsViewModel
    {
        public Enquiries.EnquiryViewModel Enquiry { get; set; }
        public BLL.Cars.Car Car { get; private set; }

        public CarDetailsViewModel()
        {
            
        }

        public CarDetailsViewModel(BLL.Cars.Car car)
        {
            this.Car = car;
            this.Enquiry = new EnquiryViewModel(car.CarID);
        }

        public CarDetailsViewModel(BLL.Cars.Car car, EnquiryViewModel enquiry)
        {
            this.Car = car;
            this.Enquiry = enquiry;
            this.Enquiry.CarID = this.Car.CarID;
        }
    }
}
