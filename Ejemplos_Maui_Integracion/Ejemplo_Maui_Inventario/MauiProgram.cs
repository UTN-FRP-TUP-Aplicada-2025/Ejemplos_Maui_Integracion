using Ejemplo_Maui_Inventario.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace Ejemplo_Maui_Inventario;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .RegisterAppServices()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        return builder.Build();
    }

    private static MauiAppBuilder RegisterAppServices(this MauiAppBuilder builder)
    {
        builder.Services.AddHttpClient("GraphQLClient", client =>
        {
            client.BaseAddress = new Uri("https://localhost:7233/graphql/");
        });

        builder.Services.AddSingleton<PersonasService>();

        return builder;
    }
}
