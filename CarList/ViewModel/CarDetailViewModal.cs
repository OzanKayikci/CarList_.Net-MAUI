using CarList.Business;
using CarList.Models;
using CarList.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CarList.ViewModel
{
    [QueryProperty("Id", "Id")]
    public partial class CarDetailViewModal : ObservableObject
    {
        IConnectivity connectivity;
        public ICarService _carService = new CarService();

        [ObservableProperty]
        int id;
        [ObservableProperty]
        public CarDetail carDetails;
        public CarDetailViewModal(IConnectivity connectivity)
        {
            this.connectivity = connectivity;
        }

        [RelayCommand]
        async Task GetCarDetails()
        {

            if (connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Uh Oh!", "No Internet. Pls Check your connection", "OK");
                return;
            }
            CarDetails = _carService.GetCarDetails(Id);
            CarDetails.Photos = CarDetails.Photos.Select(x => x.Replace("{0}", "800x600")).ToList();


        }

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }


}
