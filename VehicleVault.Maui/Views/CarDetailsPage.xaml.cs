using VehicleVault.Maui.ViewModels;

namespace VehicleVault.Maui.Views;

public partial class CarDetailsPage : ContentPage
{
	public CarDetailsPage(CarDetailsViewModel carDetailsViewModel)
	{
		InitializeComponent();
		BindingContext = carDetailsViewModel;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}