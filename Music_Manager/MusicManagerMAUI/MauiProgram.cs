using Microsoft.Extensions.Logging;

namespace MusicManagerMAUI
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<ArtistPageViewModel>();
            builder.Services.AddSingleton<ArtistPage>();
            builder.Services.AddSingleton<RatingPageViewModel>();
            builder.Services.AddSingleton<RatingPage>();
            builder.Services.AddSingleton<ArtistWithMostAlbumsPageViewModel>();
            builder.Services.AddSingleton<ArtistWithMostAlbumsPage>();
            return builder.Build();
        }
    }
}
