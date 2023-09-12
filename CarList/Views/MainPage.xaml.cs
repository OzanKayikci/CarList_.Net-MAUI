using CarList.Models;
using CarList.ViewModel;

namespace CarList.Views;

public partial class MainPage : ContentPage
{

    private readonly CarViewModal viewModel;
    IEnumerable<Car> carList;

    public MainPage(CarViewModal vm)
    {
        InitializeComponent();
        viewModel = vm;


    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.GetCarsCommand.Execute(null);
        carList = viewModel.Cars;

        if (carList != null)
        {

            carsCollection.ItemsSource = carList;
            BindingContext = viewModel;

        }


    }


}

