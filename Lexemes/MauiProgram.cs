using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Lexemes
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            MauiAppBuilder builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("TW.ttf", "Straight");
                fonts.AddFont("TW-fancy.ttf", "Fancy");
            });

            return builder.Build();
        }
    }
}
