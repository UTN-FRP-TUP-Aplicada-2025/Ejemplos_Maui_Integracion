namespace Ejemplo_WebAPI_Inventario.GraphQL.Types;

public class Inventario
{
    public Inventario(int Numero, string Descripcion)
    {
        this.Numero = Numero;
        this.Descripcion = Descripcion;
    }

    public int Numero { get; set; }
    public string Descripcion { get; set; }
}