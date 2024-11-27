using Microsoft.Extensions.Logging;

namespace MauiPlanets
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

                    fonts.AddFont("animeace2_bld.otf", "BoldFont");
                    fonts.AddFont("animeace2_ital.otf", "LightFont");
                    fonts.AddFont("animeace2_reg.otf", "RegularFont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
