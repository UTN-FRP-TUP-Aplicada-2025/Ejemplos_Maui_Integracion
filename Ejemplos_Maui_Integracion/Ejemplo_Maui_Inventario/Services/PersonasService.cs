using Ejemplo_Maui_Inventario.Models;
using System.Net.Http.Json;

namespace Ejemplo_Maui_Inventario.Services;

public class PersonasService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public PersonasService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<List<Persona>> ObtenerPersonasAsync()
    {
        var client = _httpClientFactory.CreateClient("GraphQLClient");

        var query = new
        {
            query = "{ personas { dni nombre } }" 
        };


        var response = await client.PostAsJsonAsync("", query);

        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadFromJsonAsync<GraphQLResponse>();
            return result?.Data?.Personas ?? new List<Persona>();
        }

        return new List<Persona>();
    }
}

// Clases auxiliares
public class GraphQLResponse 
{ 
    public GraphQLData Data { get; set; } 
}
public class GraphQLData 
{ 
    public List<Persona> Personas { get; set; } 

}
