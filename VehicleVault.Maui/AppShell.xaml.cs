using VehicleVault.Maui.Views;

namespace VehicleVault.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CarDetailsPage), typeof(CarDetailsPage));
        }
    }
}
