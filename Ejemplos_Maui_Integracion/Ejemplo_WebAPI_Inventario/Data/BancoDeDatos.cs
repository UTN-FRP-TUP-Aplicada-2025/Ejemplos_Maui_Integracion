using Ejemplo_WebAPI_Inventario.Data.Types;

namespace Ejemplo_WebAPI_Inventario.Data;

public static class BancoDeDatos
{
    public static List<Persona> Personas = new()
    {
        new Persona(30234323, "Ana", new List<Inventario> {
            new Inventario(101, "Laptop Dell"),
            new Inventario(102, "Mouse Logitech")
        }),
        new Persona(45623323, "Leonor", new List<Inventario> {
            new Inventario(201, "Monitor 24''")
        }),
        new Persona(35623323, "Juan", new List<Inventario> {
            new Inventario(201, "Monitor 27''")
        })
    };
}