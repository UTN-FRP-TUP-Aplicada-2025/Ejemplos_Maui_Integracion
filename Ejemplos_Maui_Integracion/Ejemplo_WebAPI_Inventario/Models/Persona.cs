namespace Ejemplo_WebAPI_Inventario.Models;

public class Persona
{
    public int Dni { get; set; }
    public string Nombre { get; set; }

    public List<Inventario> Items { get; set; }

    public Persona(int Dni, string Nombre, List<Inventario> inventarios)
    {
        this.Dni = Dni;
        this.Nombre = Nombre;
        this.Items = inventarios;
    }
}