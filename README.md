# BodegaVinosProyecto
BodegaVinosProyecto es un sistema simple de gestión de inventario para una bodega de vinos. El sistema permite registrar y gestionar los diferentes tipos de vinos en inventario, actualizar cantidades y consultar el stock disponible. Este sistema se centra exclusivamente en la gestión del inventario y no incluirá funcionalidades de ventas, proveedores o reportes complejos.

La aplicación es una **ASP.NET Core Web API**. Se utiliza una base de datos SQL (SQLlite) para almacenar la información. 

## Instalacion y uso

### 1. Copiar la url del proyecto en el repositorio.

**Ejemplo: ** `https://github.com/Frannco19/BodegaVinosTUP.git`

### 2. Uibcarse en la ruta de acceso a la terminal del proyecto.

**Ejemplo: ** `C:\Users\Ejemplo\source\repos\BodegaVinosTUP`

### 3. Clonar el repositorio de git 

**Ejemplo: ** `git clone https://github.com/usuario/BodegaDeVinosProyect.git`

### 4. Ejecutar el proyecto en la terminal del Visual Studio.

En la parte superior de el visual studio podemos encontrar un boton verde de "Iniciar sin depurar" darle click o apretar (CTRL + F5)  

La API estara disponible en la url que el visual studio le dispongaa, un ejemplo:

**URL: ** `https://localhost:7206/swagger/index.html`

## Endpoints

### Usuarios

#### 1. Crear un nuevo usuario

**URL:** `/api/user`

**Método:** `POST`

**Descripción:** Crea un nuevo usuario y se almacena localmente sin base de datos.

**Cuerpo de la solicitud:**

```json
{
  "id": 3,
  "userame": "test1",
  "password": "test1"
}
```
#### 2. Obtener un usuario por ID

**URL:** `/api/user/{id}`

**Método:** `GET`

**Descripción:** Devuelve los detalles de un usuario dado su ID.

**Cuerpo de la respuesta:**

```json
{
  "id": 3,
  "userame": "test1",
  "password": "test1"
}
```
### Vinos

#### 1. Crear un nuevo vino

**URL:** `/api/Wine`

**Método:** `POST`

**Descripción:** Registra un nuevo vino y se almacena localmente sin base de datos.

**Cuerpo de la solicitud:**

```json
{
  "id": 3,
  "name": "Malbec",
  "variety": "Tinto",
  "year": 2010,
  "region": "Mendoza, Argentina",
  "stock": 20,
  "createdAt": "2024-09-29T19:06:15.991Z"
}
```

#### 2. Obtener todos los vinos

**URL:** `/api/Wine`

**Método:** `GET`

**Descripción:** Devuelve una lista de todos los vinos registrados.

**Cuerpo de la respuesta:**

```json
[
  {
    "id": 1,
    "name": "Malbec",
    "variety": "Tinto",
    "year": 2010,
    "region": "Cordoba, Argentina",
    "stock": 10,
    "createdAt": "2024-09-29T19:06:15.991Z"
  },
  {
    "id": 2,
    "name": "Malbec",
    "variety": "Tinto",
    "year": 2015,
    "region": "Rosario, Argentina",
    "stock": 30,
    "createdAt": "2024-09-29T19:06:15.991Z"
  },
  {
  "id": 3,
  "name": "Malbec",
  "variety": "Tinto",
  "year": 2010,
  "region": "Mendoza, Argentina",
  "stock": 20,
  "createdAt": "2024-09-29T19:06:15.991Z"
}
]
```

#### 3. Obtener un vino por ID

**URL:** `/api/wine/{id}`

**Método:** `GET`

**Descripción:** Devuelve los detalles de un vino dado su ID.

**Cuerpo de la respuesta:**

```json
{
  "id": 3,
  "name": "Malbec",
  "variety": "Tinto",
  "year": 2010,
  "region": "Mendoza, Argentina",
  "stock": 20,
  "createdAt": "2024-09-29T19:06:15.991Z"
}
```
## Tecnologías utilizadas

.NET Core,
ASP.NET Core,
Inyección de dependencias (UserService, WineService)

## Base URL
Todavia no disponobile con conectividad a base de datos
