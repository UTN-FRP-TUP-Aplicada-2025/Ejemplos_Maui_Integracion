
using Ejemplo_Inventario.Pages;

namespace Ejemplo_Maui_Inventario;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(DetalleInventarioPage), typeof(DetalleInventarioPage));
    }
}
