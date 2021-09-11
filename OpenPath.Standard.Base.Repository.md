<a name='assembly'></a>
# OpenPath.Standard.Base.Repository

## Contents

- [IPlanet](#T-OpenPath-Standard-Base-Repository-Interface-IPlanet 'OpenPath.Standard.Base.Repository.Interface.IPlanet')
  - [DeleteByKey(key)](#M-OpenPath-Standard-Base-Repository-Interface-IPlanet-DeleteByKey-System-String- 'OpenPath.Standard.Base.Repository.Interface.IPlanet.DeleteByKey(System.String)')
  - [DeleteByKeyAsync(key)](#M-OpenPath-Standard-Base-Repository-Interface-IPlanet-DeleteByKeyAsync-System-String- 'OpenPath.Standard.Base.Repository.Interface.IPlanet.DeleteByKeyAsync(System.String)')
  - [KeyExistsAsync(key)](#M-OpenPath-Standard-Base-Repository-Interface-IPlanet-KeyExistsAsync-System-String- 'OpenPath.Standard.Base.Repository.Interface.IPlanet.KeyExistsAsync(System.String)')
  - [ListByEquatorialDiameter(minimum,maximum)](#M-OpenPath-Standard-Base-Repository-Interface-IPlanet-ListByEquatorialDiameter-System-Nullable{System-Double},System-Nullable{System-Double}- 'OpenPath.Standard.Base.Repository.Interface.IPlanet.ListByEquatorialDiameter(System.Nullable{System.Double},System.Nullable{System.Double})')
  - [ReadByKeyAsync(key)](#M-OpenPath-Standard-Base-Repository-Interface-IPlanet-ReadByKeyAsync-System-String- 'OpenPath.Standard.Base.Repository.Interface.IPlanet.ReadByKeyAsync(System.String)')
- [IStandardDbContext](#T-OpenPath-Standard-Base-Repository-Interface-IStandardDbContext 'OpenPath.Standard.Base.Repository.Interface.IStandardDbContext')
  - [Planets](#P-OpenPath-Standard-Base-Repository-Interface-IStandardDbContext-Planets 'OpenPath.Standard.Base.Repository.Interface.IStandardDbContext.Planets')
- [IStandardUnitOfWork](#T-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork 'OpenPath.Standard.Base.Repository.Interface.IStandardUnitOfWork')
  - [DbContext](#P-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork-DbContext 'OpenPath.Standard.Base.Repository.Interface.IStandardUnitOfWork.DbContext')
  - [Planets](#P-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork-Planets 'OpenPath.Standard.Base.Repository.Interface.IStandardUnitOfWork.Planets')
  - [Commit()](#M-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork-Commit 'OpenPath.Standard.Base.Repository.Interface.IStandardUnitOfWork.Commit')
  - [CommitAsync()](#M-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork-CommitAsync 'OpenPath.Standard.Base.Repository.Interface.IStandardUnitOfWork.CommitAsync')
- [PlanetRepository](#T-OpenPath-Standard-Base-Repository-Data-PlanetRepository 'OpenPath.Standard.Base.Repository.Data.PlanetRepository')
  - [#ctor(standardDbContext)](#M-OpenPath-Standard-Base-Repository-Data-PlanetRepository-#ctor-OpenPath-Standard-Base-Repository-StandardDbContext- 'OpenPath.Standard.Base.Repository.Data.PlanetRepository.#ctor(OpenPath.Standard.Base.Repository.StandardDbContext)')
  - [DeleteByKey(key)](#M-OpenPath-Standard-Base-Repository-Data-PlanetRepository-DeleteByKey-System-String- 'OpenPath.Standard.Base.Repository.Data.PlanetRepository.DeleteByKey(System.String)')
  - [DeleteByKeyAsync(key)](#M-OpenPath-Standard-Base-Repository-Data-PlanetRepository-DeleteByKeyAsync-System-String- 'OpenPath.Standard.Base.Repository.Data.PlanetRepository.DeleteByKeyAsync(System.String)')
  - [KeyExistsAsync(key)](#M-OpenPath-Standard-Base-Repository-Data-PlanetRepository-KeyExistsAsync-System-String- 'OpenPath.Standard.Base.Repository.Data.PlanetRepository.KeyExistsAsync(System.String)')
  - [ListByEquatorialDiameter(key)](#M-OpenPath-Standard-Base-Repository-Data-PlanetRepository-ListByEquatorialDiameter-System-Nullable{System-Double},System-Nullable{System-Double}- 'OpenPath.Standard.Base.Repository.Data.PlanetRepository.ListByEquatorialDiameter(System.Nullable{System.Double},System.Nullable{System.Double})')
  - [ReadByKeyAsync(key)](#M-OpenPath-Standard-Base-Repository-Data-PlanetRepository-ReadByKeyAsync-System-String- 'OpenPath.Standard.Base.Repository.Data.PlanetRepository.ReadByKeyAsync(System.String)')
- [StandardDbContext](#T-OpenPath-Standard-Base-Repository-StandardDbContext 'OpenPath.Standard.Base.Repository.StandardDbContext')
  - [#ctor()](#M-OpenPath-Standard-Base-Repository-StandardDbContext-#ctor 'OpenPath.Standard.Base.Repository.StandardDbContext.#ctor')
  - [#ctor(options)](#M-OpenPath-Standard-Base-Repository-StandardDbContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{OpenPath-Standard-Base-Repository-StandardDbContext}- 'OpenPath.Standard.Base.Repository.StandardDbContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{OpenPath.Standard.Base.Repository.StandardDbContext})')
  - [#ctor(connectionString)](#M-OpenPath-Standard-Base-Repository-StandardDbContext-#ctor-System-String- 'OpenPath.Standard.Base.Repository.StandardDbContext.#ctor(System.String)')
  - [_connectionString](#F-OpenPath-Standard-Base-Repository-StandardDbContext-_connectionString 'OpenPath.Standard.Base.Repository.StandardDbContext._connectionString')
  - [Planets](#P-OpenPath-Standard-Base-Repository-StandardDbContext-Planets 'OpenPath.Standard.Base.Repository.StandardDbContext.Planets')
  - [OnConfiguring(optionsBuilder)](#M-OpenPath-Standard-Base-Repository-StandardDbContext-OnConfiguring-Microsoft-EntityFrameworkCore-DbContextOptionsBuilder- 'OpenPath.Standard.Base.Repository.StandardDbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)')
  - [OnModelCreating(builder)](#M-OpenPath-Standard-Base-Repository-StandardDbContext-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder- 'OpenPath.Standard.Base.Repository.StandardDbContext.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder)')
- [StandardUnitOfWork](#T-OpenPath-Standard-Base-Repository-StandardUnitOfWork 'OpenPath.Standard.Base.Repository.StandardUnitOfWork')
  - [#ctor(standardDbContext)](#M-OpenPath-Standard-Base-Repository-StandardUnitOfWork-#ctor-OpenPath-Standard-Base-Repository-StandardDbContext- 'OpenPath.Standard.Base.Repository.StandardUnitOfWork.#ctor(OpenPath.Standard.Base.Repository.StandardDbContext)')
  - [_standardDbContext](#F-OpenPath-Standard-Base-Repository-StandardUnitOfWork-_standardDbContext 'OpenPath.Standard.Base.Repository.StandardUnitOfWork._standardDbContext')
  - [DbContext](#P-OpenPath-Standard-Base-Repository-StandardUnitOfWork-DbContext 'OpenPath.Standard.Base.Repository.StandardUnitOfWork.DbContext')
  - [Planets](#P-OpenPath-Standard-Base-Repository-StandardUnitOfWork-Planets 'OpenPath.Standard.Base.Repository.StandardUnitOfWork.Planets')
  - [Commit()](#M-OpenPath-Standard-Base-Repository-StandardUnitOfWork-Commit 'OpenPath.Standard.Base.Repository.StandardUnitOfWork.Commit')
  - [CommitAsync()](#M-OpenPath-Standard-Base-Repository-StandardUnitOfWork-CommitAsync 'OpenPath.Standard.Base.Repository.StandardUnitOfWork.CommitAsync')
  - [Dispose()](#M-OpenPath-Standard-Base-Repository-StandardUnitOfWork-Dispose 'OpenPath.Standard.Base.Repository.StandardUnitOfWork.Dispose')
  - [DisposeAsync()](#M-OpenPath-Standard-Base-Repository-StandardUnitOfWork-DisposeAsync 'OpenPath.Standard.Base.Repository.StandardUnitOfWork.DisposeAsync')

<a name='T-OpenPath-Standard-Base-Repository-Interface-IPlanet'></a>
## IPlanet `type`

##### Namespace

OpenPath.Standard.Base.Repository.Interface

##### Summary

The Interface for accessing Planet based data.

<a name='M-OpenPath-Standard-Base-Repository-Interface-IPlanet-DeleteByKey-System-String-'></a>
### DeleteByKey(key) `method`

##### Summary

Deletes a Planet by the Planet Key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Planet Key to Detele the Planet by. |

<a name='M-OpenPath-Standard-Base-Repository-Interface-IPlanet-DeleteByKeyAsync-System-String-'></a>
### DeleteByKeyAsync(key) `method`

##### Summary

Deletes a Planet by the Planet Key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Planet Key to Detele the Planet by. |

<a name='M-OpenPath-Standard-Base-Repository-Interface-IPlanet-KeyExistsAsync-System-String-'></a>
### KeyExistsAsync(key) `method`

##### Summary

Checks if the Planet name Key already exists in the database.

##### Returns

Returns True if the Key exist, False if it does not exist.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A Planet Key |

<a name='M-OpenPath-Standard-Base-Repository-Interface-IPlanet-ListByEquatorialDiameter-System-Nullable{System-Double},System-Nullable{System-Double}-'></a>
### ListByEquatorialDiameter(minimum,maximum) `method`

##### Summary

Lists all planets between a minimum equatorial diameter.

##### Returns

Returns an IQueryable list of Planets.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| minimum | [System.Nullable{System.Double}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Double}') | The mimimum equatorial diameter of a planed in kilometers. |
| maximum | [System.Nullable{System.Double}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Double}') | The maximum equatorial diameter of a planed in kilometers. |

<a name='M-OpenPath-Standard-Base-Repository-Interface-IPlanet-ReadByKeyAsync-System-String-'></a>
### ReadByKeyAsync(key) `method`

##### Summary

Looks up a Planet by the Planet Key.

##### Returns

Returns a Planet.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Planet Key to look up the Planet by. |

<a name='T-OpenPath-Standard-Base-Repository-Interface-IStandardDbContext'></a>
## IStandardDbContext `type`

##### Namespace

OpenPath.Standard.Base.Repository.Interface

##### Summary

The base database connection context Interface for connecting to the database.

<a name='P-OpenPath-Standard-Base-Repository-Interface-IStandardDbContext-Planets'></a>
### Planets `property`

##### Summary

Represents a planet in our solar system.

<a name='T-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork'></a>
## IStandardUnitOfWork `type`

##### Namespace

OpenPath.Standard.Base.Repository.Interface

##### Summary

The base interface used for all CRUD operations agianst the repository for the the database.

<a name='P-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork-DbContext'></a>
### DbContext `property`

##### Summary

Reference to the DB Context underlying the Unit of Work.

<a name='P-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork-Planets'></a>
### Planets `property`

##### Summary

Represents a planet repository in our solar system.

<a name='M-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork-Commit'></a>
### Commit() `method`

##### Summary

Commits all database changes to this unit of work.

##### Returns

The amout of rows updated.

##### Parameters

This method has no parameters.

<a name='M-OpenPath-Standard-Base-Repository-Interface-IStandardUnitOfWork-CommitAsync'></a>
### CommitAsync() `method`

##### Summary

Commits all database changes to this unit of work.

##### Returns

The amout of rows updated.

##### Parameters

This method has no parameters.

<a name='T-OpenPath-Standard-Base-Repository-Data-PlanetRepository'></a>
## PlanetRepository `type`

##### Namespace

OpenPath.Standard.Base.Repository.Data

##### Summary

*Inherit from parent.*

##### Summary

The class for accessing Planet based data.

<a name='M-OpenPath-Standard-Base-Repository-Data-PlanetRepository-#ctor-OpenPath-Standard-Base-Repository-StandardDbContext-'></a>
### #ctor(standardDbContext) `constructor`

##### Summary

The Planet Repository for accessing Planet data in the database.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| standardDbContext | [OpenPath.Standard.Base.Repository.StandardDbContext](#T-OpenPath-Standard-Base-Repository-StandardDbContext 'OpenPath.Standard.Base.Repository.StandardDbContext') | The database context that contains the Planet data. |

<a name='M-OpenPath-Standard-Base-Repository-Data-PlanetRepository-DeleteByKey-System-String-'></a>
### DeleteByKey(key) `method`

##### Summary

Deletes a Planet by the Planet Key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Planet Key to Detele the Planet by. |

<a name='M-OpenPath-Standard-Base-Repository-Data-PlanetRepository-DeleteByKeyAsync-System-String-'></a>
### DeleteByKeyAsync(key) `method`

##### Summary

Deletes a Planet by the Planet Key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Planet Key to Detele the Planet by. |

<a name='M-OpenPath-Standard-Base-Repository-Data-PlanetRepository-KeyExistsAsync-System-String-'></a>
### KeyExistsAsync(key) `method`

##### Summary

Looks up a Planet by the Planet Key.

##### Returns

Returns a Planet.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Planet Key to look up the Planet by. |

<a name='M-OpenPath-Standard-Base-Repository-Data-PlanetRepository-ListByEquatorialDiameter-System-Nullable{System-Double},System-Nullable{System-Double}-'></a>
### ListByEquatorialDiameter(key) `method`

##### Summary

Checks if the Planet name Key already exists in the database.

##### Returns

Returns True if the Key exist, False if it does not exist.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Nullable{System.Double}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Double}') | A Planet Key |

<a name='M-OpenPath-Standard-Base-Repository-Data-PlanetRepository-ReadByKeyAsync-System-String-'></a>
### ReadByKeyAsync(key) `method`

##### Summary

Looks up a Planet by the Planet Key.

##### Returns

Returns a Planet.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Planet Key to look up the Planet by. |

<a name='T-OpenPath-Standard-Base-Repository-StandardDbContext'></a>
## StandardDbContext `type`

##### Namespace

OpenPath.Standard.Base.Repository

##### Summary

The base database connection context for connecting to the database.

<a name='M-OpenPath-Standard-Base-Repository-StandardDbContext-#ctor'></a>
### #ctor() `constructor`

##### Summary

This constructor should only be used when using Entity Framework Code first and is used
when creating, updating or modifying database objects. The constructor will use this
local libraries project.json file to initalize the database string for connections.

##### Parameters

This constructor has no parameters.

<a name='M-OpenPath-Standard-Base-Repository-StandardDbContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{OpenPath-Standard-Base-Repository-StandardDbContext}-'></a>
### #ctor(options) `constructor`

##### Summary

This contructor can be used by Dependancy Injection when injecting the DBContext
Options.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.EntityFrameworkCore.DbContextOptions{OpenPath.Standard.Base.Repository.StandardDbContext}](#T-Microsoft-EntityFrameworkCore-DbContextOptions{OpenPath-Standard-Base-Repository-StandardDbContext} 'Microsoft.EntityFrameworkCore.DbContextOptions{OpenPath.Standard.Base.Repository.StandardDbContext}') | The options to be used by a DbContext. You normally override
OnConfiguring(DbContextOptionsBuilder) or use a DbContextOptionsBuilder to create
instances of this class and it is not designed to be directly constructed in your
application code. |

<a name='M-OpenPath-Standard-Base-Repository-StandardDbContext-#ctor-System-String-'></a>
### #ctor(connectionString) `constructor`

##### Summary

This contructor can be used by Dependancy Injection when injecting the database
connection string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| connectionString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The connection string for the database. |

<a name='F-OpenPath-Standard-Base-Repository-StandardDbContext-_connectionString'></a>
### _connectionString `constants`

##### Summary

Internal connection string for connecting to the database.

<a name='P-OpenPath-Standard-Base-Repository-StandardDbContext-Planets'></a>
### Planets `property`

##### Summary

Represents a planet in our solar system.

<a name='M-OpenPath-Standard-Base-Repository-StandardDbContext-OnConfiguring-Microsoft-EntityFrameworkCore-DbContextOptionsBuilder-'></a>
### OnConfiguring(optionsBuilder) `method`

##### Summary

This method is called for each instance of the context that is created. The base
implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| optionsBuilder | [Microsoft.EntityFrameworkCore.DbContextOptionsBuilder](#T-Microsoft-EntityFrameworkCore-DbContextOptionsBuilder 'Microsoft.EntityFrameworkCore.DbContextOptionsBuilder') | A builder used to create or modify options for this context. Databases (and other
extensions) typically define extension methods on this object that allow you to
configure the context. |

<a name='M-OpenPath-Standard-Base-Repository-StandardDbContext-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### OnModelCreating(builder) `method`

##### Summary

This method is called when the model for a derived context has been initialized, but
before the model has been locked down and used to initialize the context. The default
implementation of this method does nothing, but it can be overridden in a derived
class such that the model can be further configured before it is locked down.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.EntityFrameworkCore.ModelBuilder](#T-Microsoft-EntityFrameworkCore-ModelBuilder 'Microsoft.EntityFrameworkCore.ModelBuilder') | Defines the shape of your entities, the relationships between them, and how they map to
the database. |

<a name='T-OpenPath-Standard-Base-Repository-StandardUnitOfWork'></a>
## StandardUnitOfWork `type`

##### Namespace

OpenPath.Standard.Base.Repository

##### Summary

The base class used for all CRUD operations agianst the repository for the the database.

<a name='M-OpenPath-Standard-Base-Repository-StandardUnitOfWork-#ctor-OpenPath-Standard-Base-Repository-StandardDbContext-'></a>
### #ctor(standardDbContext) `constructor`

##### Summary

This is constructor should be used by the dependancy inject of the calling project to
initalize the Unit of Work for the database.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| standardDbContext | [OpenPath.Standard.Base.Repository.StandardDbContext](#T-OpenPath-Standard-Base-Repository-StandardDbContext 'OpenPath.Standard.Base.Repository.StandardDbContext') | A DbContext instance represents a combination of the Unit Of Work and Repository
patterns such that it can be used to query from a database and group together changes
that will then be written back to the store as a unit. DbContext is conceptually
similar to ObjectContext. |

<a name='F-OpenPath-Standard-Base-Repository-StandardUnitOfWork-_standardDbContext'></a>
### _standardDbContext `constants`

##### Summary

The private context for the Unit of Work.

<a name='P-OpenPath-Standard-Base-Repository-StandardUnitOfWork-DbContext'></a>
### DbContext `property`

##### Summary

Reference to the DB Context underlying the Unit of Work.

<a name='P-OpenPath-Standard-Base-Repository-StandardUnitOfWork-Planets'></a>
### Planets `property`

##### Summary

Represents a planet repository in our solar system.

<a name='M-OpenPath-Standard-Base-Repository-StandardUnitOfWork-Commit'></a>
### Commit() `method`

##### Summary

Commits all database changes to this unit of work.

##### Returns

The amout of rows updated.

##### Parameters

This method has no parameters.

<a name='M-OpenPath-Standard-Base-Repository-StandardUnitOfWork-CommitAsync'></a>
### CommitAsync() `method`

##### Summary

Commits all database changes to this unit of work.

##### Returns

The amout of rows updated.

##### Parameters

This method has no parameters.

<a name='M-OpenPath-Standard-Base-Repository-StandardUnitOfWork-Dispose'></a>
### Dispose() `method`

##### Summary

Required for memory cleanup and release and reset unmanaged resources, such as file
handles and database connections.

##### Parameters

This method has no parameters.

<a name='M-OpenPath-Standard-Base-Repository-StandardUnitOfWork-DisposeAsync'></a>
### DisposeAsync() `method`

##### Summary

Required for memory cleanup and release and reset unmanaged resources, such as file
handles and database connections.

##### Parameters

This method has no parameters.
