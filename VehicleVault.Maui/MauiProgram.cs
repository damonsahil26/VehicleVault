using Microsoft.Extensions.Logging;
using VehicleVault.Maui.Services;
using VehicleVault.Maui.ViewModels;
using VehicleVault.Maui.Views;

namespace VehicleVault.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<CarViewModel>();
            builder.Services.AddSingleton<CarService>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<CarDetailsViewModel>();
            builder.Services.AddTransient<CarDetailsPage>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
