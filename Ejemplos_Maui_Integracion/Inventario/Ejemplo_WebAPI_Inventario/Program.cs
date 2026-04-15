using Ejemplo_WebAPI_Inventario.GraphQL.Mutations;
using Ejemplo_WebAPI_Inventario.GraphQL.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL(); 

await app.RunAsync();