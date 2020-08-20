###Bienvenido a mi proyecto Prueba para GoalSystems

**Instucciones de Ejecución**

- Descargar proyecto desde GitHud desde la sugiente ruta:
[https://github.com/chalbaso-git/prueba](https://github.com/chalbaso-git/prueba)
- Instalar IDE de Visual Studio para poder ejecutar la aplicación
-En la solución encontrarán dos proyectos que son:

	- ServicesInventario: Este proyecto contiene el código necesario para la ejecución del servicio API Rest.
	- WebAPI_MVC_Inventario: Este proyecto contiene el código con la interfaz para la ejecución del servicio API Rest.

- En el proyecto ServicesInventario dar click derecho.
- Seleccionar la opcción "Publicar"
- Dar click en el botón iniciar de la sección "Publicar";
- Del listado, seleccionar la opción "Carpeta" para dejar el servicio API Rest local
- Damos click en "Siguiente!
- Seleccionaremos la ruta donde quedará nuestros archivos
- Luego damos click en "Finalizar"
- Después dar click en "Publicar"
- Posterior, se debe abrir IIS
- Nos ubicamos en "Sitio"
- Click derecho y damos la opción "Agregar sitio web"
- Asignar un nombre al sitio"
- Después dar click en "Publicar"
- En "Ruta de acceso física se debe seleccionar la ruta donde quedo publicado el servicio API Rest.
- Luego de haber creado el sitio web, damos click derecho sobre el mismo.
- Seleecionamos "Editar permisos".
- Vamos a la pestaña "Seguridad".
- Click en "Editar"
- Luego "Agregar"
- En el campo en blanco ingresamos el usuario IIS_IUSRS.
- Luego "Comprobar nombre" y después aceptar.
- Le asignamos permisos de "Control total" y damos "Aceptar".
- Luego actualizamos el sitio web y cerramos IIS.
- En la solucción, nos pararemos en el proyecto "WebAPI_MVC_Inventario",
- Damos click derecho y luego seleccionamos la opción "Establecer como proyecto de origen"

Con esto ya se puede realizar la validación del desarrollo.

**Documentación**

Solución creada bajo el IDE de Visual Studio 2019.  Se crean dos proyectos: 

- "ServicesInventario" creado como aplicación web ASP.Net Core, Framework 3.1 proyecto API.
- "WebAPI_MVC_Inventario" creado como aplicación web ASP.NET(.NET Framework), Framework , proyecto MVC.
- Los datos se almacena en memoria desde la API.


**Atajos**

- Se omitió la creación de login, el cual hubiera permitido tener un grado de seguridad dentro del proyecto.
- Se exceptuó la creación de Modelo donde se listaba los tipos de productos.
- Se pudo haber incluido opciones con valores decimales que permitieran saber el costo total de los articulos en el inventario.

**Test**

- GET (ListarProducto)
	https://localhost:44384/Api/Inventario
	
- POST (Agregar nuevo productos)
	https://localhost:44384/Api/Inventario/agregar
	{
	"Nombre": "Producto7",
	"FechaCaducidad": "12/08/2020"
	}

- DELETE (Eliminar producto)
	https://localhost:44384/Api/Inventario/1
