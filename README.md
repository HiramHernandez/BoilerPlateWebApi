Este proyecto tiene como objetivo servir de plantilla para futuros proyectos
basados en la plantilla de WebApi de ASP.NET Core (dotnet 6).

A diferencia de las arquitecturas empresariales basadas en proyectos (que son las mas convenientes),
este plantilla basara las capas no en proyectos sino en carpeta dentro de un proyecto con su solución.
Las principales razones para hacerlo de esta manera serian:

• Si el equipo de desarollo es pequeño (un número como siempre subjetivo).
• Si los desarrolladores no estan acostumbrados a arquitecras empresariales (muy complejo al principio).
• Si el editor a utilizar no es Visual Studio (el cual facilita el uso de arquitectura empresariales).
• Si es necesario entregar resultados "pronto".
• Si el proyecto a desarollar es relativamente sencillo.
• Por meras preferencias personales.

Aún asi el equipo de desarrollo se debe de comprometer a crear un codigo desacoplado, cohesionado, en fin bien organizado.

Como luce una arqitectura tipica empresarial, puede variar segun autores.
• Proyecto de Presentación:
	MyApp.WebApi (contiene los controladores, DTOs, configuración de la API).

• Proyecto de Aplicación:
	MyApp.Application (contiene los servicios de aplicación, mappers).

• Proyecto de Dominio:
	MyApp.Domain (contiene las entidades, value objects, repositorios).

• Proyecto de Infraestructura:
	MyApp.Infrastructure (contiene la implementación de repositorios, contextos de base de datos, servicios externos).

• Proyecto de Persistencia:
	MyApp.Persistence (contiene las migraciones, configuración de base de datos).

Las depencias de nuget que incluye esta plantilla son:
	• AutoMapper 12.0.0
	• AutoMapper.Extensions.Microsoft.DependencyInjection 12.0.0
	• Microsoft.EntityFrameworkCore.SqlServer 6.0.0 (se puede utilizar otro)
	• Microsoft.EntityFrameworkCore.Tools 6.0.0

Al clonar el repositorio para empezar a derivar un oroyecto de el, si se usa Visual Studio
simplemente se restauran los paquetes de nuget para instalarlos.
En caso de usar otro editor como Visual Studio Code se puede utilizar *dotnet cli* posiconado
en la carpeta y con un terminar ejecutar dotnet restore.

