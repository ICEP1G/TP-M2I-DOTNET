using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TP_M2I_DOTNET.Services;
using TP_M2I_DOTNET.ViewModels;
using TP_M2I_DOTNET.Views;

namespace TP_M2I_DOTNET
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<FakeDataService>();
            builder.Services.AddSingleton<IPetService, PetFakeDataService>();
            builder.Services.AddSingleton<IOrderService, OrderFakeDataService>();

            // Pages
            builder.Services.AddTransient<MainPage, MainPageViewModel>();
            builder.Services.AddTransient<PetPage, PetPageViewModel>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
