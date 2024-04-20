using Microsoft.Extensions.Logging;
using PokemonApplication.Interfaces;
using PokemonApplication.Services;
using PokemonApplication.View;
using PokemonApplication.ViewModels;

namespace PokemonApplication
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


            builder.Services.AddSingleton<IPokemonApiService,PokemonApiService>();

            builder.Services.AddSingleton<ListOfPokemonsViewModel>();
            builder.Services.AddTransient<OnePokemonInfoViewModel>();
            builder.Services.AddSingleton<CheckYourKnowledgeViewModel>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<OnePokemonPage>();
            builder.Services.AddSingleton<CheckYourKnowledgePage>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
