using System;
using Carlister.Common.DTO;
using Carlister.Common.Enums;

namespace Carlister.BLL.Cars
{
    public static class CarFactory
    {
        public static Car CreateCar(ICar carData)
        {
            switch ((SaleType)carData.SaleType)
            {
                case SaleType.PrivateSale:
                case SaleType.DealerSale:
                default:
                    return new Car(carData);
                    // Alternative: return DefaultCar
                    throw new NotImplementedException();
            }
        }
    }
}
