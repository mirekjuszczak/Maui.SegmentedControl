using Microsoft.Extensions.Logging;
using SegmentedControl.Services;
using SegmentedControl.ViewModels;
using SegmentedControl.Views;

namespace SegmentedControl;

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
        
        RegisterViewModelsAndPages(builder);
        RegisterServices(builder);

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
    
    private static void RegisterViewModelsAndPages(MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();
        
        builder.Services.AddSingleton<GesturePage>();
        builder.Services.AddSingleton<GesturePageViewModel>();
        
        builder.Services.AddSingleton<SegmentedControlPage>();
        builder.Services.AddSingleton<SegmentedControlPageViewModel>();
        
        builder.Services.AddSingleton<SwipePage>();
        builder.Services.AddSingleton<SwipePageViewModel>();
    }

    private static void RegisterServices(MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<INavigationService, NavigationService>();
    }
}