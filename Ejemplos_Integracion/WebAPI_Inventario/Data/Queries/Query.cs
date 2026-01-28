using WebAPI_Inventario.Models;

namespace WebAPI_Inventario.Data.Queries;

public class Query
{
    public List<Persona> GetPersonas() => BancoDeDatos.Personas;

     public Persona? GetPersona(int dni) =>
        BancoDeDatos.Personas.FirstOrDefault(p => p.Dni == dni);
}
