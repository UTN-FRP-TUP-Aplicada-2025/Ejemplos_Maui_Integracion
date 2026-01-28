

## consola
https://localhost:7233/graphql/


## NuGET
```
dotnet add package HotChocolate.AspNetCore
```


## Queries Ejemplos: 

```
query {
  personas {
    dni
    nombre
  }
}
```

```
query {
  persona(dni: 123) {
    nombre
    items {
      numero
      descripcion
    }
  }
}
```


Ejemplos
https://beta.pokeapi.co/graphql/console