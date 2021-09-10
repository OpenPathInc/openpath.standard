<a name='assembly'></a>
# OpenPath.Standard.Base.Service

## Contents

- [IPlanetService](#T-OpenPath-Standard-Base-Service-Interface-IPlanetService 'OpenPath.Standard.Base.Service.Interface.IPlanetService')
  - [AddUpdateAsync(planet)](#M-OpenPath-Standard-Base-Service-Interface-IPlanetService-AddUpdateAsync-OpenPath-Standard-Base-Data-Database-PlanetModel- 'OpenPath.Standard.Base.Service.Interface.IPlanetService.AddUpdateAsync(OpenPath.Standard.Base.Data.Database.PlanetModel)')
  - [AddUpdateAsync(planet)](#M-OpenPath-Standard-Base-Service-Interface-IPlanetService-AddUpdateAsync-System-Collections-Generic-IEnumerable{OpenPath-Standard-Base-Data-Database-PlanetModel}- 'OpenPath.Standard.Base.Service.Interface.IPlanetService.AddUpdateAsync(System.Collections.Generic.IEnumerable{OpenPath.Standard.Base.Data.Database.PlanetModel})')
  - [GetAsync(id)](#M-OpenPath-Standard-Base-Service-Interface-IPlanetService-GetAsync-System-Int64- 'OpenPath.Standard.Base.Service.Interface.IPlanetService.GetAsync(System.Int64)')
  - [GetAsync(id)](#M-OpenPath-Standard-Base-Service-Interface-IPlanetService-GetAsync-System-String- 'OpenPath.Standard.Base.Service.Interface.IPlanetService.GetAsync(System.String)')
  - [ListAsync(filter)](#M-OpenPath-Standard-Base-Service-Interface-IPlanetService-ListAsync-OpenPath-Standard-Base-Data-Poco-PlanetFilterPoco- 'OpenPath.Standard.Base.Service.Interface.IPlanetService.ListAsync(OpenPath.Standard.Base.Data.Poco.PlanetFilterPoco)')
  - [RemoveAsync(id)](#M-OpenPath-Standard-Base-Service-Interface-IPlanetService-RemoveAsync-System-Int64- 'OpenPath.Standard.Base.Service.Interface.IPlanetService.RemoveAsync(System.Int64)')
  - [RemoveAsync(id)](#M-OpenPath-Standard-Base-Service-Interface-IPlanetService-RemoveAsync-System-String- 'OpenPath.Standard.Base.Service.Interface.IPlanetService.RemoveAsync(System.String)')
- [PlanetService](#T-OpenPath-Standard-Base-Service-PlanetService 'OpenPath.Standard.Base.Service.PlanetService')
  - [#ctor(standardUnitOfWork)](#M-OpenPath-Standard-Base-Service-PlanetService-#ctor-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork- 'OpenPath.Standard.Base.Service.PlanetService.#ctor(OpenPath.Standard.Base.Repository.Interface.IStandardUnitOfWork)')
  - [LARGE_PLANET_MINIMUM](#F-OpenPath-Standard-Base-Service-PlanetService-LARGE_PLANET_MINIMUM 'OpenPath.Standard.Base.Service.PlanetService.LARGE_PLANET_MINIMUM')
  - [MEDIUM_PLANET_MAXIMUM](#F-OpenPath-Standard-Base-Service-PlanetService-MEDIUM_PLANET_MAXIMUM 'OpenPath.Standard.Base.Service.PlanetService.MEDIUM_PLANET_MAXIMUM')
  - [MEDIUM_PLANET_MINIMUM](#F-OpenPath-Standard-Base-Service-PlanetService-MEDIUM_PLANET_MINIMUM 'OpenPath.Standard.Base.Service.PlanetService.MEDIUM_PLANET_MINIMUM')
  - [SMALL_PLANET_MAXIMUM](#F-OpenPath-Standard-Base-Service-PlanetService-SMALL_PLANET_MAXIMUM 'OpenPath.Standard.Base.Service.PlanetService.SMALL_PLANET_MAXIMUM')
  - [_standardUnitOfWork](#F-OpenPath-Standard-Base-Service-PlanetService-_standardUnitOfWork 'OpenPath.Standard.Base.Service.PlanetService._standardUnitOfWork')
  - [AddUpdateAsync(planet)](#M-OpenPath-Standard-Base-Service-PlanetService-AddUpdateAsync-OpenPath-Standard-Base-Data-Database-PlanetModel- 'OpenPath.Standard.Base.Service.PlanetService.AddUpdateAsync(OpenPath.Standard.Base.Data.Database.PlanetModel)')
  - [AddUpdateAsync(planet)](#M-OpenPath-Standard-Base-Service-PlanetService-AddUpdateAsync-System-Collections-Generic-IEnumerable{OpenPath-Standard-Base-Data-Database-PlanetModel}- 'OpenPath.Standard.Base.Service.PlanetService.AddUpdateAsync(System.Collections.Generic.IEnumerable{OpenPath.Standard.Base.Data.Database.PlanetModel})')
  - [GetAsync(id)](#M-OpenPath-Standard-Base-Service-PlanetService-GetAsync-System-Int64- 'OpenPath.Standard.Base.Service.PlanetService.GetAsync(System.Int64)')
  - [GetAsync(id)](#M-OpenPath-Standard-Base-Service-PlanetService-GetAsync-System-String- 'OpenPath.Standard.Base.Service.PlanetService.GetAsync(System.String)')
  - [ListAsync(filter)](#M-OpenPath-Standard-Base-Service-PlanetService-ListAsync-OpenPath-Standard-Base-Data-Poco-PlanetFilterPoco- 'OpenPath.Standard.Base.Service.PlanetService.ListAsync(OpenPath.Standard.Base.Data.Poco.PlanetFilterPoco)')
  - [RemoveAsync(id)](#M-OpenPath-Standard-Base-Service-PlanetService-RemoveAsync-System-Int64- 'OpenPath.Standard.Base.Service.PlanetService.RemoveAsync(System.Int64)')
  - [RemoveAsync(id)](#M-OpenPath-Standard-Base-Service-PlanetService-RemoveAsync-System-String- 'OpenPath.Standard.Base.Service.PlanetService.RemoveAsync(System.String)')
  - [generateKeyAsync(name,checkIfExists)](#M-OpenPath-Standard-Base-Service-PlanetService-generateKeyAsync-System-String,System-Boolean- 'OpenPath.Standard.Base.Service.PlanetService.generateKeyAsync(System.String,System.Boolean)')
  - [updateChanged(originalPlanet,updatedPlanet)](#M-OpenPath-Standard-Base-Service-PlanetService-updateChanged-OpenPath-Standard-Base-Data-Database-PlanetModel,OpenPath-Standard-Base-Data-Database-PlanetModel- 'OpenPath.Standard.Base.Service.PlanetService.updateChanged(OpenPath.Standard.Base.Data.Database.PlanetModel,OpenPath.Standard.Base.Data.Database.PlanetModel)')

<a name='T-OpenPath-Standard-Base-Service-Interface-IPlanetService'></a>
## IPlanetService `type`

##### Namespace

OpenPath.Standard.Base.Service.Interface

##### Summary

Service to Manage Planets.

<a name='M-OpenPath-Standard-Base-Service-Interface-IPlanetService-AddUpdateAsync-OpenPath-Standard-Base-Data-Database-PlanetModel-'></a>
### AddUpdateAsync(planet) `method`

##### Summary

This method will add or update the Planet passed to it. If the Planet already has a
Planet ID that is greater than zero (0) then the method will lookup and update the
exist Planet, if the Planet ID is less than or equal to zero (0), then it will add the
Planet.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| planet | [OpenPath.Standard.Base.Data.Database.PlanetModel](#T-OpenPath-Standard-Base-Data-Database-PlanetModel 'OpenPath.Standard.Base.Data.Database.PlanetModel') | The Planet to Add or Update. |

<a name='M-OpenPath-Standard-Base-Service-Interface-IPlanetService-AddUpdateAsync-System-Collections-Generic-IEnumerable{OpenPath-Standard-Base-Data-Database-PlanetModel}-'></a>
### AddUpdateAsync(planet) `method`

##### Summary

This method will add or update an array of Planets passed to it. The Planets will be
sorted by what needs to be added or updated based on the following parameters: If the
Planet already has a Planet ID that is greater than zero (0) then the method will
lookup and update the exist Planet, if the Planet ID is less than or equal to zero (0),
then it will add the Planet.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| planet | [System.Collections.Generic.IEnumerable{OpenPath.Standard.Base.Data.Database.PlanetModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{OpenPath.Standard.Base.Data.Database.PlanetModel}') | The Planet to Add or Update. |

<a name='M-OpenPath-Standard-Base-Service-Interface-IPlanetService-GetAsync-System-Int64-'></a>
### GetAsync(id) `method`

##### Summary

Get a Planet by the Planet ID.

##### Returns

A Planet associated to the ID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The ID of the Planet. |

<a name='M-OpenPath-Standard-Base-Service-Interface-IPlanetService-GetAsync-System-String-'></a>
### GetAsync(id) `method`

##### Summary

Get a Planet by the Planet Key.

##### Returns

A Planet associated to the Key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Key of the Planet. |

<a name='M-OpenPath-Standard-Base-Service-Interface-IPlanetService-ListAsync-OpenPath-Standard-Base-Data-Poco-PlanetFilterPoco-'></a>
### ListAsync(filter) `method`

##### Summary

Returns a paged list of Planets based on the filter and the maximum amount of items
allowed per page.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [OpenPath.Standard.Base.Data.Poco.PlanetFilterPoco](#T-OpenPath-Standard-Base-Data-Poco-PlanetFilterPoco 'OpenPath.Standard.Base.Data.Poco.PlanetFilterPoco') | The filter(s) to apply to this list. |

<a name='M-OpenPath-Standard-Base-Service-Interface-IPlanetService-RemoveAsync-System-Int64-'></a>
### RemoveAsync(id) `method`

##### Summary

Remove a Planet by the Planet ID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The ID of the Planet. |

<a name='M-OpenPath-Standard-Base-Service-Interface-IPlanetService-RemoveAsync-System-String-'></a>
### RemoveAsync(id) `method`

##### Summary

Remove a Planet by the Planet Key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Key of the Planet. |

<a name='T-OpenPath-Standard-Base-Service-PlanetService'></a>
## PlanetService `type`

##### Namespace

OpenPath.Standard.Base.Service

##### Summary

The base service class for calling planets and all the subsets of data from each planet.

<a name='M-OpenPath-Standard-Base-Service-PlanetService-#ctor-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork-'></a>
### #ctor(standardUnitOfWork) `constructor`

##### Summary

The injectable constructor for the planet service that connects the service to the
database.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| standardUnitOfWork | [OpenPath.Standard.Base.Repository.Interface.IStandardUnitOfWork](#T-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork 'OpenPath.Standard.Base.Repository.Interface.IStandardUnitOfWork') | The unit of work for Planets. |

<a name='F-OpenPath-Standard-Base-Service-PlanetService-LARGE_PLANET_MINIMUM'></a>
### LARGE_PLANET_MINIMUM `constants`

##### Summary

The minimum size of a large planet.

<a name='F-OpenPath-Standard-Base-Service-PlanetService-MEDIUM_PLANET_MAXIMUM'></a>
### MEDIUM_PLANET_MAXIMUM `constants`

##### Summary

The maximum size of a medimum sized planet.

<a name='F-OpenPath-Standard-Base-Service-PlanetService-MEDIUM_PLANET_MINIMUM'></a>
### MEDIUM_PLANET_MINIMUM `constants`

##### Summary

The mimimum size of a medimum sized planet.

<a name='F-OpenPath-Standard-Base-Service-PlanetService-SMALL_PLANET_MAXIMUM'></a>
### SMALL_PLANET_MAXIMUM `constants`

##### Summary

The maximum size of a planet that is small.

<a name='F-OpenPath-Standard-Base-Service-PlanetService-_standardUnitOfWork'></a>
### _standardUnitOfWork `constants`

##### Summary

The injected unit of work for the data where the planet exists.

<a name='M-OpenPath-Standard-Base-Service-PlanetService-AddUpdateAsync-OpenPath-Standard-Base-Data-Database-PlanetModel-'></a>
### AddUpdateAsync(planet) `method`

##### Summary

This method will add or update the Planet passed to it. If the Planet already has a
Planet ID that is greater than zero (0) then the method will lookup and update the
exist Planet, if the Planet ID is less than or equal to zero (0), then it will add the
Planet.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| planet | [OpenPath.Standard.Base.Data.Database.PlanetModel](#T-OpenPath-Standard-Base-Data-Database-PlanetModel 'OpenPath.Standard.Base.Data.Database.PlanetModel') | The Planet to Add or Update. |

<a name='M-OpenPath-Standard-Base-Service-PlanetService-AddUpdateAsync-System-Collections-Generic-IEnumerable{OpenPath-Standard-Base-Data-Database-PlanetModel}-'></a>
### AddUpdateAsync(planet) `method`

##### Summary

This method will add or update an array of Planets passed to it. The Planets will be
sorted by what needs to be added or updated based on the following parameters: If the
Planet already has a Planet ID that is greater than zero (0) then the method will
lookup and update the exist Planet, if the Planet ID is less than or equal to zero (0),
then it will add the Planet.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| planet | [System.Collections.Generic.IEnumerable{OpenPath.Standard.Base.Data.Database.PlanetModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{OpenPath.Standard.Base.Data.Database.PlanetModel}') | The Planet to Add or Update. |

<a name='M-OpenPath-Standard-Base-Service-PlanetService-GetAsync-System-Int64-'></a>
### GetAsync(id) `method`

##### Summary

Get a Planet by the Planet ID.

##### Returns

A Planet associated to the ID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The ID of the Planet. |

<a name='M-OpenPath-Standard-Base-Service-PlanetService-GetAsync-System-String-'></a>
### GetAsync(id) `method`

##### Summary

Get a Planet by the Planet Key.

##### Returns

A Planet associated to the Key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Key of the Planet. |

<a name='M-OpenPath-Standard-Base-Service-PlanetService-ListAsync-OpenPath-Standard-Base-Data-Poco-PlanetFilterPoco-'></a>
### ListAsync(filter) `method`

##### Summary

Returns a paged list of Planets based on the filter and the maximum amount of items
allowed per page.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [OpenPath.Standard.Base.Data.Poco.PlanetFilterPoco](#T-OpenPath-Standard-Base-Data-Poco-PlanetFilterPoco 'OpenPath.Standard.Base.Data.Poco.PlanetFilterPoco') | The filter(s) to apply to this list. |

<a name='M-OpenPath-Standard-Base-Service-PlanetService-RemoveAsync-System-Int64-'></a>
### RemoveAsync(id) `method`

##### Summary

Remove a Planet by the Planet ID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The ID of the Planet. |

<a name='M-OpenPath-Standard-Base-Service-PlanetService-RemoveAsync-System-String-'></a>
### RemoveAsync(id) `method`

##### Summary

Remove a Planet by the Planet Key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Key of the Planet. |

<a name='M-OpenPath-Standard-Base-Service-PlanetService-generateKeyAsync-System-String,System-Boolean-'></a>
### generateKeyAsync(name,checkIfExists) `method`

##### Summary

Creates an URL cased version of the Planet name, if it already exists and the check if
exists flag is not set then this method will throw a Duplicate Name Expection.

##### Returns

The URL cased name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the Planet. |
| checkIfExists | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If empty or true will throw a Duplicate Name Expection if
the name exists. |

<a name='M-OpenPath-Standard-Base-Service-PlanetService-updateChanged-OpenPath-Standard-Base-Data-Database-PlanetModel,OpenPath-Standard-Base-Data-Database-PlanetModel-'></a>
### updateChanged(originalPlanet,updatedPlanet) `method`

##### Summary

Checks for changes between the updated Planet and original Planet and only updates the
Planet if the values are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| originalPlanet | [OpenPath.Standard.Base.Data.Database.PlanetModel](#T-OpenPath-Standard-Base-Data-Database-PlanetModel 'OpenPath.Standard.Base.Data.Database.PlanetModel') | Original Planet. |
| updatedPlanet | [OpenPath.Standard.Base.Data.Database.PlanetModel](#T-OpenPath-Standard-Base-Data-Database-PlanetModel 'OpenPath.Standard.Base.Data.Database.PlanetModel') | Updated Planet. |
