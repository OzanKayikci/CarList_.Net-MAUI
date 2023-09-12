using CarList.Models;
using CarList.Services;

/* Unmerged change from project 'CarList (net7.0-windows10.0.19041.0)'
Before:
using System.Threading.Tasks;
using CarList.Models;
using CarList.Services;
After:
using System.Threading.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
*/

/* Unmerged change from project 'CarList (net7.0-ios)'
Before:
using System.Threading.Tasks;
using CarList.Models;
using CarList.Services;
After:
using System.Threading.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
*/

/* Unmerged change from project 'CarList (net7.0-android)'
Before:
using System.Threading.Tasks;
using CarList.Models;
using CarList.Services;
After:
using System.Threading.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
*/
using System.Collections.ObjectModel;
//using Microsoft.Extensions.Caching.Memory;

namespace CarList.Business
{
    public class CarService : ICarService
    {
        private readonly ICarApiService _carApiService = new CarApiService();
        private ICacheManager _cacheManager;

        private ObservableCollection<Car> cars;
        public CarService()
        {
            //   _carApiService = carApiService;
            // _cacheManager = cacheManager;


        }

        public  ObservableCollection<Car> GetCars(int count)
        {
            //if (_cacheManager.Get<ObservableCollection<Car>>("CarsCache") is ObservableCollection<Car> cachedCars)
            //{
            //    return cachedCars;
            //}

            var cars =  _carApiService.GetCars(count);

            cars = cars.Select(x =>
            {
                x.photo = x.photo.Replace("{0}", "800x600");
                return x;
            }).ToList();

            this.cars = new ObservableCollection<Car>(cars);

            //this._cacheManager.Set("CarsCache", this.cars);

            return this.cars;
        }
        public CarDetail GetCarDetails(int id)
        {
            var carDetails = _carApiService.GetCarDetails(id);

            return carDetails;
        }

        public void ClearCache()
        {
            _cacheManager.Remove("CarsCache");
        }
    }
}
