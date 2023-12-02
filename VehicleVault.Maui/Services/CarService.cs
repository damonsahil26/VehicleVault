using VehicleVault.Maui.Models;

namespace VehicleVault.Maui.Services
{
    public class CarService
    {
        public List<Car> GetCars()
        {
            return [
                new() { Id = 1, Brand = "Tata", Model = "Nano", Vin = "ABC123" },
                new() { Id = 2, Brand = "Maruti Suzuki", Model = "Nexon", Vin = "MARUTI123" },
                new() { Id = 3, Brand = "BMW", Model = "M3", Vin = "BMW123" },
                new() { Id = 4, Brand = "Audi", Model = "A5", Vin = "AUDI123" },
                new() { Id = 5, Brand = "Nissan", Model = "Sunny", Vin = "NISSAN123" },
                new() { Id = 6, Brand = "Ferrari", Model = "Spider", Vin = "FER123" },
            ];
        }
    }
}
