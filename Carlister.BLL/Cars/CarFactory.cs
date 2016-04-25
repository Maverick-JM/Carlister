using System;
using Carlister.Common.DTO;
using Carlister.Common.Enums;

namespace Carlister.BLL.Cars
{
    public static class CarFactory
    {
        public static Car CreateCar(ICar carData)
        {
            if (carData != null)
            {
                switch ((SaleType)carData.SaleType)
                {
                    case SaleType.PrivateSale:
                    case SaleType.DealerSale:
                    default:
                        return new Car(carData);
                        // Alternative: return DefaultCar or throw not implemented exception for default
                        // return child class of abstract Car class for other types
                }
            }
            else
                return null;
        }
    }
}
