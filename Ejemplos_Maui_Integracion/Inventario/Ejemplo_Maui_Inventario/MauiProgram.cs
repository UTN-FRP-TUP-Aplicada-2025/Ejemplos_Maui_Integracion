using Ejemplo_Maui_Inventario.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace Ejemplo_Maui_Inventario;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder()
            .UseMauiApp<App>()
            .AddAppServices()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        /*
         * .Services.AddHttpClient("GraphQLClient", client =>
            {
                client.BaseAddress = new Uri("https://localhost:7233/graphql/");
            })
            .Services.AddSingleton<PersonasService>();
         */

#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }

    //Métodos de Extensión (Extension Methods)
    private static MauiAppBuilder AddAppServices(this MauiAppBuilder builder)
    {
        builder.Services.AddHttpClient("GraphQLClient", client =>
        {
            client.BaseAddress = new Uri("https://localhost:7233/graphql/");
        });

        builder.Services.AddSingleton<PersonasService>();

        return builder;
    }
}
