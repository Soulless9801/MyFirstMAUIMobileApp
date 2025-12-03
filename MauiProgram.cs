using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MyFirstMAUIMobileApp.ViewModels;
using MyFirstMAUIMobileApp.Views;

namespace MyFirstMAUIMobileApp
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif      

            try
            {
                builder.Services.AddSingleton<CollectionButtonsViewModel>();
                builder.Services.AddSingleton<CollectionButtonsPage>();
            }
            catch (Exception ex)
            {
                
            }

            return builder.Build();
        }
    }
}
