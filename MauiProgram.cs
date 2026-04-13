using Microsoft.Extensions.Logging;

namespace Attendify
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
                        fonts.AddFont("PublicSans-Regular.ttf", "PublicSans-Regular");
    fonts.AddFont("PublicSans-Bold.ttf", "PublicSans-Bold");
    fonts.AddFont("PublicSans-SemiBold.ttf", "PublicSans-SemiBold");
    fonts.AddFont("Roboto-Medium.ttf", "Roboto-Medium");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
