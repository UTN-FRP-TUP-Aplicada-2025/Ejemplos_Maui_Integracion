using Ejemplo_WebAPI_Inventario.Data.Types;

namespace Ejemplo_WebAPI_Inventario.Data.Mutations;

public class Mutation
{
    public Persona AddPersona(int dni, string nombre)
    {
        var nuevaPersona = new Persona(dni, nombre, new List<Inventario>());
        BancoDeDatos.Personas.Add(nuevaPersona);

        return nuevaPersona;
    }

    public Inventario AddItem(int dniPersona, int numeroItem, string descripcionItem)
    {
        
        var persona = BancoDeDatos.Personas.FirstOrDefault(p => p.Dni == dniPersona);

        if (persona == null)
        {
            throw new Exception($"No se encontró una persona con DNI {dniPersona}");
        }

        var nuevoItem = new Inventario(numeroItem, descripcionItem);
        persona.Items.Add(nuevoItem);

        return nuevoItem;
    }
}