using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;
using LittleDay.Auth0;
using LittleDay.Services;
using LittleDay.ViewModels;
using LittleDay.Views;

namespace LittleDay
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                 .UseMauiCommunityToolkit();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<IOpenWeatherService, OpenWeatherService>();
            builder.Services.AddTransient<SearchResultViewModel>();
            builder.Services.AddTransient<SearchResult>();
            builder.Services.AddSingleton<ILittleDayService, LittleDayService>();
            builder.Services.AddSingleton<HomeViewModel>();
            builder.Services.AddSingleton<LoginViewModel>();
            builder.Services.AddSingleton<IUsuarioService, UsuarioService>();
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<LoginPage>();

            builder.Services.AddSingleton(new Auth0Client(new()
            {
                Domain = "dev-ivagjb5svrj2eelh.us.auth0.com",
                ClientId = "bzTuVR2gxK1bVvVyJCG87L2p3oDOMO9S",
                Audience = "https://localhost:44386",
                Scope = "openid profile",
                #if WINDOWS
                    RedirectUri = "myapp://callback"
#else
                    RedirectUri = "myapp://callback"
#endif
            }));

            return builder.Build();
        }
    }
}
