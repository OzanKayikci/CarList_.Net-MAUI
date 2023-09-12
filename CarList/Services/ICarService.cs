using CarList.Models;
using System.Collections.ObjectModel;

namespace CarList.Services
{
    public interface ICarService
    {
        public ObservableCollection<Car> GetCars(int count);
        public CarDetail GetCarDetails(int id);
        public void ClearCache();


    }
}
