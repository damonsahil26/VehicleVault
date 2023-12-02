using VehicleVault.Maui.ViewModels;

namespace VehicleVault.Maui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(CarViewModel carViewModel)
        {
            InitializeComponent();
            BindingContext = carViewModel;
        }
    }

}
