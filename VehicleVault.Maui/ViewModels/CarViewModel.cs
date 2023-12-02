using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleVault.Maui.Models;
using VehicleVault.Maui.Services;
using VehicleVault.Maui.Views;

namespace VehicleVault.Maui.ViewModels
{
    public partial class CarViewModel : BaseViewModel
    {
        public readonly CarService carService;
        public ObservableCollection<Car> Cars { get; set; } = [];

        [ObservableProperty]
        private bool _isRefreshing;

        public CarViewModel(CarService carService)
        {
            Title = "Cars List";
            this.carService = carService;
        }

        [RelayCommand]
        async Task GetCarList()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;

                if (Cars.Any())
                {
                    Cars.Clear();
                }

                var carsFromDb = carService.GetCars();

                foreach (var car in carsFromDb) Cars.Add(car);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                await Shell.Current.DisplayAlert("Error", "There is an error in loading car list...", "Ok");
            }
            finally
            {
                IsBusy = false;
                IsRefreshing = false;
            }
        }

        [RelayCommand]
        async Task GetCarDetails(Car car)
        {
            if (car == null) return;

            await Shell.Current.GoToAsync(nameof(CarDetailsPage), true, new Dictionary<string, object>
            {
                { nameof(Car), car }
            });
        }
    }
}
