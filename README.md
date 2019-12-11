# netcore3_1JwtAuthentication
Netcore 3.1 project. 

Con este código se puede iniciar un proyecto en netcore 3.1 para realizar login y generar el JWT (JSON Web Token).

Dentro encontramos:

## Shared Project : 
Donde están los modelos de entidades y View Models.
## Business Project: 
Donde se manejan los servicios del negocio.
## Web: 
El projecto web.

En el proyecto Business podemos encontrar que los servicios se manejan con Dependency Injection.


Para probar el login se usa el api

```bash
http://localhost:5003/api/login
```
con el siguiente JSON que contiene los datos de autenticación
```bash
{
  "email": "user@gmail.com",
  "password": "123456"
}
```

La autenticación en este proyecto simplemente se realiza comparando dos string, pero se puede adaptar a cualquier método que vayan a implementar para este fin.


## Contribución
Cualquier mejora es bienvenida!!!
