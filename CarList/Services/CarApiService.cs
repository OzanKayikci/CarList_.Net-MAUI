using CarList.Models;
using Newtonsoft.Json;

namespace CarList.Services
{
    public class CarApiService : ICarApiService
    {


        public CarDetail GetCarDetails(int id)
        {
            HttpClient client = new HttpClient();
            var json = client.GetStringAsync($"https://sandbox.arabamd.com/api/v1/detail?id={id}").Result;
            return JsonConvert.DeserializeObject<CarDetail>(json);
        }

        public IEnumerable<Car> GetCars(int take)
        {
            HttpClient client = new HttpClient();
            var json =  client.GetStringAsync($"https://sandbox.arabamd.com/api/v1/listing?sort=1&sortDirection=0&take={take}").Result;
            return JsonConvert.DeserializeObject<IEnumerable<Car>>(json.ToString());
        }
    }
}
