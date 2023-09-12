

using CarList.Business;
using CarList.Models;
using CarList.Services;
using CarList.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CarList.ViewModel
{
    public partial class CarViewModal : ObservableObject
    {
        private IConnectivity _connectivity;

        public readonly ICarService _carService = new CarService();

        [ObservableProperty]
        public ObservableCollection<Car> cars;

        [ObservableProperty]
        bool isLoading = false;
        [ObservableProperty]
        bool isShowing = true;

        public CarViewModal(IConnectivity connectivity)
        {


            _connectivity = connectivity;
            Cars = new ObservableCollection<Car>();


        }


        [ObservableProperty]
        string count = "10";


        [RelayCommand]
        public async Task GetCars()
        {
            if (string.IsNullOrEmpty(Count))
            {
                return;
            }
            if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Uh Oh!", "No Internet. Pls Check your connection", "OK");
                return;
            }

            Cars.Clear();
            IsLoading = true;
            IsShowing = false;

            OnPropertyChanged(nameof(IsLoading));
            OnPropertyChanged(nameof(IsShowing));
            var carsTemp = _carService.GetCars(int.Parse(Count));


            foreach (var car in carsTemp)
            {
                Cars.Add(car);
            }
            await Task.Delay(500);
            IsLoading = false;
            IsShowing = true;

            OnPropertyChanged(nameof(IsLoading));
            OnPropertyChanged(nameof(IsShowing));


        }

        [RelayCommand]
        async Task Tap(int id)
        {
            await Shell.Current.GoToAsync($"{nameof(CarDetailPage)}?Id={id}");
        }
    }
}
