using Ejemplo_WebAPI_Inventario.Data;
using Ejemplo_WebAPI_Inventario.GraphQL.Types;

namespace Ejemplo_WebAPI_Inventario.GraphQL.Queries;

public class Query
{
    public List<Persona> GetPersonas() => BancoDeDatos.Personas;

     public Persona? GetPersona(int dni) =>
        BancoDeDatos.Personas.FirstOrDefault(p => p.Dni == dni);
}
