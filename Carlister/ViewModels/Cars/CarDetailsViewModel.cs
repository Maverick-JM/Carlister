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
            this.Enquiry = new Enquiries.EnquiryViewModel();
        }

        public CarDetailsViewModel(BLL.Cars.Car car) : this()
        {
            this.Car = car;
        }
    }
}
