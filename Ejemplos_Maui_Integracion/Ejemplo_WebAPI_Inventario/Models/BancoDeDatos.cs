namespace Ejemplo_WebAPI_Inventario.Models;

public static class BancoDeDatos
{
    public static List<Persona> Personas = new()
    {
        new Persona(123, "Juan Perez", new List<Inventario> {
            new Inventario(101, "Laptop Dell"),
            new Inventario(102, "Mouse Logitech")
        }),
        new Persona(456, "Ana Lopez", new List<Inventario> {
            new Inventario(201, "Monitor 24''")
        })
    };
}