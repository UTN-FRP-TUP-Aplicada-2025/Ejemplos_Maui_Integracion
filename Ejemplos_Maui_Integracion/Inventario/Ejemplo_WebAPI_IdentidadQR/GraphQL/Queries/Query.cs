using Ejemplo_WebAPI_IdentidadQR.Data;
using Ejemplo_WebAPI_IdentidadQR.Data.Types;

namespace Ejemplo_WebAPI_Inventario.Data.Queries;

public class Query
{
    public List<Persona> GetPersonas() => BancoDeDatos.Personas;

     public Persona? GetPersona(int dni) =>
        BancoDeDatos.Personas.FirstOrDefault(p => p.Dni == dni);
}
