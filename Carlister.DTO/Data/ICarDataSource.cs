using System.Linq;

namespace Carlister.Common.Data
{
    public interface ICarDataSource : IDataSource<DTO.ICar>
    {
        IQueryable<DTO.ICar> GetCars();
        DTO.ICar GetCar(int carID);
    }
}
