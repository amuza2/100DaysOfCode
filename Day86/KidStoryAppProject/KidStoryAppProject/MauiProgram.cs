using Microsoft.Extensions.Logging;

namespace KidStoryAppProject
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

                builder.Services.AddSingleton<IStoryRepository, ArabicStoryRepository>();
                builder.Services.AddSingleton<IStoryService, StoryService>();
                builder.Services.AddSingleton<ITextToSpeechService, TextToSpeechService>();
                builder.Services.AddTransient<Story1>();
                builder.Services.AddTransient<MainPage>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
