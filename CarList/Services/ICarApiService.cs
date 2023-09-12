using CarList.Models;

namespace CarList.Services
{
    public interface ICarApiService
    {
        public IEnumerable<Car> GetCars(int take);
        public CarDetail GetCarDetails(int id);
    }
}
