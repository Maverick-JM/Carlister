using System.Linq;

namespace Carlister.Common.Data
{
    public interface ICarDataSource : IDataSource
    {
        IQueryable<DTO.ICar> GetCars();
        DTO.ICar GetCar(int carID);
    }
}
