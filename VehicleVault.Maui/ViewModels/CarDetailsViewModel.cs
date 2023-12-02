using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;
using VehicleVault.Maui.Models;

namespace VehicleVault.Maui.ViewModels
{
    [QueryProperty(nameof(Car),"Car")]
    public partial class CarDetailsViewModel :BaseViewModel
    {
        [ObservableProperty]
        public Car _car = new();

        public CarDetailsViewModel()
        {
        }
    }
}
