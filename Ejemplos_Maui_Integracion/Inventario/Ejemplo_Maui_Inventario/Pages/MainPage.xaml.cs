using Ejemplo_Inventario.Pages;
using Ejemplo_Maui_Inventario.Models;
using Ejemplo_Maui_Inventario.Services;
using System.Collections.Generic;

namespace Ejemplo_Maui_Inventario.Pages;

public partial class MainPage : ContentPage
{
    private readonly PersonasService _service=default!;

    List<Persona> _personas = new ();
    public List<Persona> Personas 
    {
        get
        {
            return _personas;
        }
        set
        {
            if (value != _personas)
            { 
                _personas = value;
                OnPropertyChanged();
            }
        } 
    }
        
    public MainPage(PersonasService service)
    {
        InitializeComponent();

        BindingContext = this;

        _service = service;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        Personas = await _service.ObtenerPersonasAsync();       
    }

    async private void OnMostrarDetallePersonaSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var persona = e.CurrentSelection.FirstOrDefault() as Persona;
        if (persona == null) return;

        var queryParam=new ShellNavigationQueryParameters();
        queryParam.Add("detalle", persona);

        await Shell.Current.GoToAsync(nameof(DetalleInventarioPage), queryParam);

        ((CollectionView)sender).SelectedItem = null;
    }
}
