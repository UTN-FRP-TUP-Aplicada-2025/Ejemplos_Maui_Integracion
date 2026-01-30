using Ejemplo_WebAPI_IdentidadQR.Data.Types;

namespace Ejemplo_WebAPI_Inventario.Models;

public static class BancoDeDatos
{
    public static List<Persona> Personas = new()
    {
        new Persona{ Dni=30456465, Nombre="Ana" },
        new Persona{ Dni=35457156, Nombre="Leonor"}
    };
}