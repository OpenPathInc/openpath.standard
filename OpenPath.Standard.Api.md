<a name='assembly'></a>
# OpenPath.Standard.Api

## Contents

- [BaseContoller](#T-OpenPath-Standard-Api-Controllers-BaseContoller 'OpenPath.Standard.Api.Controllers.BaseContoller')
- [PlanetsController](#T-OpenPath-Standard-Api-Controllers-PlanetsController 'OpenPath.Standard.Api.Controllers.PlanetsController')
  - [#ctor(loggerFactory,planetService)](#M-OpenPath-Standard-Api-Controllers-PlanetsController-#ctor-Microsoft-Extensions-Logging-ILoggerFactory,OpenPath-Standard-Base-Service-Interface-IPlanetService- 'OpenPath.Standard.Api.Controllers.PlanetsController.#ctor(Microsoft.Extensions.Logging.ILoggerFactory,OpenPath.Standard.Base.Service.Interface.IPlanetService)')
  - [_logger](#F-OpenPath-Standard-Api-Controllers-PlanetsController-_logger 'OpenPath.Standard.Api.Controllers.PlanetsController._logger')
  - [_loggerFactory](#F-OpenPath-Standard-Api-Controllers-PlanetsController-_loggerFactory 'OpenPath.Standard.Api.Controllers.PlanetsController._loggerFactory')
  - [_planetService](#F-OpenPath-Standard-Api-Controllers-PlanetsController-_planetService 'OpenPath.Standard.Api.Controllers.PlanetsController._planetService')
  - [DeleteAsync(idKey)](#M-OpenPath-Standard-Api-Controllers-PlanetsController-DeleteAsync-System-String- 'OpenPath.Standard.Api.Controllers.PlanetsController.DeleteAsync(System.String)')
  - [Get(filter)](#M-OpenPath-Standard-Api-Controllers-PlanetsController-Get-OpenPath-Standard-Base-Data-Poco-PlanetFilterPoco- 'OpenPath.Standard.Api.Controllers.PlanetsController.Get(OpenPath.Standard.Base.Data.Poco.PlanetFilterPoco)')
  - [Get(idKey)](#M-OpenPath-Standard-Api-Controllers-PlanetsController-Get-System-String- 'OpenPath.Standard.Api.Controllers.PlanetsController.Get(System.String)')
  - [PostAsync(planets)](#M-OpenPath-Standard-Api-Controllers-PlanetsController-PostAsync-System-Collections-Generic-IEnumerable{OpenPath-Standard-Base-Data-Database-PlanetModel}- 'OpenPath.Standard.Api.Controllers.PlanetsController.PostAsync(System.Collections.Generic.IEnumerable{OpenPath.Standard.Base.Data.Database.PlanetModel})')
- [Program](#T-OpenPath-Standard-Api-Program 'OpenPath.Standard.Api.Program')
  - [CreateHostBuilder(args)](#M-OpenPath-Standard-Api-Program-CreateHostBuilder-System-String[]- 'OpenPath.Standard.Api.Program.CreateHostBuilder(System.String[])')
  - [Main(args)](#M-OpenPath-Standard-Api-Program-Main-System-String[]- 'OpenPath.Standard.Api.Program.Main(System.String[])')
- [Startup](#T-OpenPath-Standard-Api-Startup 'OpenPath.Standard.Api.Startup')
  - [#ctor(configuration)](#M-OpenPath-Standard-Api-Startup-#ctor-Microsoft-Extensions-Configuration-IConfiguration- 'OpenPath.Standard.Api.Startup.#ctor(Microsoft.Extensions.Configuration.IConfiguration)')
  - [Configuration](#P-OpenPath-Standard-Api-Startup-Configuration 'OpenPath.Standard.Api.Startup.Configuration')
  - [Configure(applicationBuilder,hostEnvironment)](#M-OpenPath-Standard-Api-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-AspNetCore-Hosting-IWebHostEnvironment- 'OpenPath.Standard.Api.Startup.Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.AspNetCore.Hosting.IWebHostEnvironment)')
  - [ConfigureServices(services)](#M-OpenPath-Standard-Api-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'OpenPath.Standard.Api.Startup.ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')

<a name='T-OpenPath-Standard-Api-Controllers-BaseContoller'></a>
## BaseContoller `type`

##### Namespace

OpenPath.Standard.Api.Controllers

##### Summary

Base controller for API endpoints.

<a name='T-OpenPath-Standard-Api-Controllers-PlanetsController'></a>
## PlanetsController `type`

##### Namespace

OpenPath.Standard.Api.Controllers

##### Summary

Endpoints for managing Planet data.

<a name='M-OpenPath-Standard-Api-Controllers-PlanetsController-#ctor-Microsoft-Extensions-Logging-ILoggerFactory,OpenPath-Standard-Base-Service-Interface-IPlanetService-'></a>
### #ctor(loggerFactory,planetService) `constructor`

##### Summary

The Planets endpoint constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loggerFactory | [Microsoft.Extensions.Logging.ILoggerFactory](#T-Microsoft-Extensions-Logging-ILoggerFactory 'Microsoft.Extensions.Logging.ILoggerFactory') | The Microsoft Logger Factory. |
| planetService | [OpenPath.Standard.Base.Service.Interface.IPlanetService](#T-OpenPath-Standard-Base-Service-Interface-IPlanetService 'OpenPath.Standard.Base.Service.Interface.IPlanetService') | Service to Manage Planets. |

<a name='F-OpenPath-Standard-Api-Controllers-PlanetsController-_logger'></a>
### _logger `constants`

##### Summary

A generic interface for logging where the category name is derived from the specified
TCategoryName type name. Generally used to enable activation of a named
Microsoft.Extensions.Logging.ILogger from dependency injection.

<a name='F-OpenPath-Standard-Api-Controllers-PlanetsController-_loggerFactory'></a>
### _loggerFactory `constants`

##### Summary

Represents a type used to configure the logging system and create instances of
Microsoft.Extensions.Logging.ILogger from the registered
Microsoft.Extensions.Logging.ILoggerProviders.

<a name='F-OpenPath-Standard-Api-Controllers-PlanetsController-_planetService'></a>
### _planetService `constants`

##### Summary

Service to Manage Planets.

<a name='M-OpenPath-Standard-Api-Controllers-PlanetsController-DeleteAsync-System-String-'></a>
### DeleteAsync(idKey) `method`

##### Summary

Deletes a single Planet by Planet ID or Planet Key.

##### Returns

If the delete was successfull.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| idKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Planet ID or Key. |

<a name='M-OpenPath-Standard-Api-Controllers-PlanetsController-Get-OpenPath-Standard-Base-Data-Poco-PlanetFilterPoco-'></a>
### Get(filter) `method`

##### Summary

Gets a filtered array of Planets.

##### Returns

Returns an evelope with filtered planets in the data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [OpenPath.Standard.Base.Data.Poco.PlanetFilterPoco](#T-OpenPath-Standard-Base-Data-Poco-PlanetFilterPoco 'OpenPath.Standard.Base.Data.Poco.PlanetFilterPoco') | Filter Parameters |

<a name='M-OpenPath-Standard-Api-Controllers-PlanetsController-Get-System-String-'></a>
### Get(idKey) `method`

##### Summary

Returns a single Planet by Planet ID or Planet Key.

##### Returns

A an Envelope with Planet data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| idKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Planet ID or Key. |

<a name='M-OpenPath-Standard-Api-Controllers-PlanetsController-PostAsync-System-Collections-Generic-IEnumerable{OpenPath-Standard-Base-Data-Database-PlanetModel}-'></a>
### PostAsync(planets) `method`

##### Summary

Accepts an array of new or updated planets and either creates or updates them. This
endpoint can handle a mixture of both.

##### Returns

Returns an evelope with the updated and/or created planets in the data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| planets | [System.Collections.Generic.IEnumerable{OpenPath.Standard.Base.Data.Database.PlanetModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{OpenPath.Standard.Base.Data.Database.PlanetModel}') | An array of Planets. |

<a name='T-OpenPath-Standard-Api-Program'></a>
## Program `type`

##### Namespace

OpenPath.Standard.Api

##### Summary

This is the main API program staring point that fires up the hosting services and Start Up
class.

<a name='M-OpenPath-Standard-Api-Program-CreateHostBuilder-System-String[]-'></a>
### CreateHostBuilder(args) `method`

##### Summary

Create the web host and fires off the Start Up class.

##### Returns

A running web hosting environment.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Takes the arguments from the Main method. |

<a name='M-OpenPath-Standard-Api-Program-Main-System-String[]-'></a>
### Main(args) `method`

##### Summary

This is the Main entry method to fire off the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | A string of optional parameters. |

<a name='T-OpenPath-Standard-Api-Startup'></a>
## Startup `type`

##### Namespace

OpenPath.Standard.Api

##### Summary

The entry point to the application, setting up configuration and wiring up services the
application will use.

<a name='M-OpenPath-Standard-Api-Startup-#ctor-Microsoft-Extensions-Configuration-IConfiguration-'></a>
### #ctor(configuration) `constructor`

##### Summary

The start up constructor for this class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | Represents a set of key/value application configuration properties. |

<a name='P-OpenPath-Standard-Api-Startup-Configuration'></a>
### Configuration `property`

##### Summary

Represents a set of key/value application configuration properties.

<a name='M-OpenPath-Standard-Api-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-AspNetCore-Hosting-IWebHostEnvironment-'></a>
### Configure(applicationBuilder,hostEnvironment) `method`

##### Summary

This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| applicationBuilder | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') | Defines a class that provides the mechanisms to configure an application's request pipeline. |
| hostEnvironment | [Microsoft.AspNetCore.Hosting.IWebHostEnvironment](#T-Microsoft-AspNetCore-Hosting-IWebHostEnvironment 'Microsoft.AspNetCore.Hosting.IWebHostEnvironment') | Provides information about the web hosting environment an application is running in. |

<a name='M-OpenPath-Standard-Api-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureServices(services) `method`

##### Summary

This method gets called by the runtime. Use this method to add services to the container.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Specifies the contract for a collection of service descriptors. |
