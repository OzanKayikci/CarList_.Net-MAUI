using CarList.Models;
using CarList.ViewModel;

namespace CarList.Views;

public partial class CarDetailPage : ContentPage
{
    private readonly CarDetailViewModal viewModel;
    CarDetail carDetail;
    public CarDetailPage(CarDetailViewModal vm)
    {
        InitializeComponent();
        viewModel = vm;
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.GetCarDetailsCommand.Execute(null);
        carDetail = viewModel.CarDetails;

        if (carDetail != null)
        {

            BindingContext = viewModel;
            DetailImages.ItemsSource = carDetail.Photos;

            //foreach (PropertyBase detail in carDetail.properties)
            //{
            //    Label nameLabel = CreateLabel(detail.name, true);
            //    Grid.SetRow(nameLabel, detailGrid.Count + 2);
            //    Grid.SetColumn(nameLabel, 0);
            //    detailGrid.Children.Add(nameLabel);

            //    Label valueLabel = CreateLabel(detail.value,false);
            //    Grid.SetRow(valueLabel, detailGrid.Count + 2);
            //    Grid.SetColumn(valueLabel, 0);

            //    detailGrid.Children.Add(valueLabel);

            /* Unmerged change from project 'CarList (net7.0-windows10.0.19041.0)'
            Before:
                        //}


                    }
            After:
                        //}


                    }
            */

            /* Unmerged change from project 'CarList (net7.0-ios)'
            Before:
                        //}


                    }
            After:
                        //}


                    }
            */

            /* Unmerged change from project 'CarList (net7.0-android)'
            Before:
                        //}


                    }
            After:
                        //}


                    }
            */
            //}



            /* Unmerged change from project 'CarList (net7.0-windows10.0.19041.0)'
            Before:
                    }


                private Label CreateLabel( string text, bool isName)
            After:
                }


                private Label CreateLabel( string text, bool isName)
            */

            /* Unmerged change from project 'CarList (net7.0-ios)'
            Before:
                    }


                private Label CreateLabel( string text, bool isName)
            After:
                }


                private Label CreateLabel( string text, bool isName)
            */

            /* Unmerged change from project 'CarList (net7.0-android)'
            Before:
                    }


                private Label CreateLabel( string text, bool isName)
            After:
                }


                private Label CreateLabel( string text, bool isName)
            */
        }

    }


    private Label CreateLabel(string text, bool isName)
    {


        Label label = new()
        {
            Text = text,

            HorizontalTextAlignment = TextAlignment.Start,
            VerticalTextAlignment = TextAlignment.Start,
            TextColor = isName ? Color.FromHex(colorAsArgbHex: "#ACACAC") : Colors.Beige,
            FontSize = (double)NamedSize.Small,
        };


        return label;
    }
}