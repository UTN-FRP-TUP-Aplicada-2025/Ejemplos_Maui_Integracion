using Ejemplo_Maui_Inventario.Models;

namespace Ejemplo_Inventario.Pages;

[QueryProperty(nameof(Persona),"detalle")]
public partial class DetalleInventarioPage : ContentPage
{

	Persona persona;
	public Persona Persona 
	{
		get
		{ 
			return persona;  
		}
		set 
		{ 
			persona = value;
			OnPropertyChanged();
		}
	}

	public DetalleInventarioPage()
	{
		InitializeComponent();

		BindingContext = this;
	}
}