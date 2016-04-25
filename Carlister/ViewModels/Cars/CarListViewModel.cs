using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlister.Web.ViewModels.Cars
{
    public class CarListViewModel
    {
        public List<BLL.Cars.Car> Cars { get; set; }

        public CarListViewModel()
        {

        }

        public CarListViewModel(List<BLL.Cars.Car> cars)
        {
            this.Cars = cars;
        }
    }
}
