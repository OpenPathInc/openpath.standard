<a name='assembly'></a>
# WebApiSoftware-Util-Repo

## Contents

- [BaseRepository\`2](#T-WebApi-Software-Utility-Repository-Data-BaseRepository`2 'WebApi.Software.Utility.Repository.Data.BaseRepository`2')
  - [#ctor(dbContext)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-#ctor-Microsoft-EntityFrameworkCore-DbContext- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.#ctor(Microsoft.EntityFrameworkCore.DbContext)')
  - [_dbContext](#F-WebApi-Software-Utility-Repository-Data-BaseRepository`2-_dbContext 'WebApi.Software.Utility.Repository.Data.BaseRepository`2._dbContext')
  - [_dbSet](#F-WebApi-Software-Utility-Repository-Data-BaseRepository`2-_dbSet 'WebApi.Software.Utility.Repository.Data.BaseRepository`2._dbSet')
  - [Create(entity)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-Create-`0- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.Create(`0)')
  - [CreateAsync(entity)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-CreateAsync-`0- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.CreateAsync(`0)')
  - [CreateRange(entities)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-CreateRange-System-Collections-Generic-IEnumerable{`0}- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.CreateRange(System.Collections.Generic.IEnumerable{`0})')
  - [CreateRangeAsync(entities)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-CreateRangeAsync-System-Collections-Generic-IEnumerable{`0}- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.CreateRangeAsync(System.Collections.Generic.IEnumerable{`0})')
  - [Delete(entity)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-Delete-`0- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.Delete(`0)')
  - [DeleteById(id)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-DeleteById-`1- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.DeleteById(`1)')
  - [DeleteRange(entities)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-DeleteRange-System-Collections-Generic-IEnumerable{`0}- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.DeleteRange(System.Collections.Generic.IEnumerable{`0})')
  - [DeleteRangeById(ids)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-DeleteRangeById-System-Collections-Generic-IEnumerable{`1}- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.DeleteRangeById(System.Collections.Generic.IEnumerable{`1})')
  - [Filter(query,filter)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-Filter-System-Linq-IQueryable{`0},WebApi-Software-Utility-Repository-Interface-IFilter- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.Filter(System.Linq.IQueryable{`0},WebApi.Software.Utility.Repository.Interface.IFilter)')
  - [Read()](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-Read 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.Read')
  - [ReadById(id)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-ReadById-`1- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.ReadById(`1)')
  - [ReadByIdAsync(id)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-ReadByIdAsync-`1- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.ReadByIdAsync(`1)')
  - [Update(entity)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-Update-`0- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.Update(`0)')
  - [UpdateAsync(entity)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-UpdateAsync-`0- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.UpdateAsync(`0)')
  - [getPrimaryKey(entity)](#M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-getPrimaryKey-`0- 'WebApi.Software.Utility.Repository.Data.BaseRepository`2.getPrimaryKey(`0)')
- [DataHelper](#T-WebApi-Software-Utility-Repository-Helper-DataHelper 'WebApi.Software.Utility.Repository.Helper.DataHelper')
  - [CompareAndReplace\`\`1(existingObject,newObject)](#M-WebApi-Software-Utility-Repository-Helper-DataHelper-CompareAndReplace``1-System-Object,System-Object- 'WebApi.Software.Utility.Repository.Helper.DataHelper.CompareAndReplace``1(System.Object,System.Object)')
- [FilterAbstract](#T-WebApi-Software-Utility-Repository-Abstract-FilterAbstract 'WebApi.Software.Utility.Repository.Abstract.FilterAbstract')
  - [Limit](#P-WebApi-Software-Utility-Repository-Abstract-FilterAbstract-Limit 'WebApi.Software.Utility.Repository.Abstract.FilterAbstract.Limit')
  - [Page](#P-WebApi-Software-Utility-Repository-Abstract-FilterAbstract-Page 'WebApi.Software.Utility.Repository.Abstract.FilterAbstract.Page')
  - [Clone()](#M-WebApi-Software-Utility-Repository-Abstract-FilterAbstract-Clone 'WebApi.Software.Utility.Repository.Abstract.FilterAbstract.Clone')
  - [Clone(page)](#M-WebApi-Software-Utility-Repository-Abstract-FilterAbstract-Clone-System-Int32- 'WebApi.Software.Utility.Repository.Abstract.FilterAbstract.Clone(System.Int32)')
- [FilterPoco](#T-WebApi-Software-Utility-Repository-Poco-FilterPoco 'WebApi.Software.Utility.Repository.Poco.FilterPoco')
  - [Clone()](#M-WebApi-Software-Utility-Repository-Poco-FilterPoco-Clone 'WebApi.Software.Utility.Repository.Poco.FilterPoco.Clone')
  - [Clone(page)](#M-WebApi-Software-Utility-Repository-Poco-FilterPoco-Clone-System-Int32- 'WebApi.Software.Utility.Repository.Poco.FilterPoco.Clone(System.Int32)')
- [IFilter](#T-WebApi-Software-Utility-Repository-Interface-IFilter 'WebApi.Software.Utility.Repository.Interface.IFilter')
  - [Limit](#P-WebApi-Software-Utility-Repository-Interface-IFilter-Limit 'WebApi.Software.Utility.Repository.Interface.IFilter.Limit')
  - [Page](#P-WebApi-Software-Utility-Repository-Interface-IFilter-Page 'WebApi.Software.Utility.Repository.Interface.IFilter.Page')
  - [Clone()](#M-WebApi-Software-Utility-Repository-Interface-IFilter-Clone 'WebApi.Software.Utility.Repository.Interface.IFilter.Clone')
  - [Clone(page)](#M-WebApi-Software-Utility-Repository-Interface-IFilter-Clone-System-Int32- 'WebApi.Software.Utility.Repository.Interface.IFilter.Clone(System.Int32)')
- [IRepository\`2](#T-WebApi-Software-Utility-Repository-Interface-IRepository`2 'WebApi.Software.Utility.Repository.Interface.IRepository`2')
  - [Create(entity)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-Create-`0- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.Create(`0)')
  - [CreateAsync(entity)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-CreateAsync-`0- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.CreateAsync(`0)')
  - [CreateRange(entities)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-CreateRange-System-Collections-Generic-IEnumerable{`0}- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.CreateRange(System.Collections.Generic.IEnumerable{`0})')
  - [CreateRangeAsync(entities)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-CreateRangeAsync-System-Collections-Generic-IEnumerable{`0}- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.CreateRangeAsync(System.Collections.Generic.IEnumerable{`0})')
  - [Delete(entity)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-Delete-`0- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.Delete(`0)')
  - [DeleteById(id)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-DeleteById-`1- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.DeleteById(`1)')
  - [DeleteRange(entities)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-DeleteRange-System-Collections-Generic-IEnumerable{`0}- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.DeleteRange(System.Collections.Generic.IEnumerable{`0})')
  - [DeleteRangeById(ids)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-DeleteRangeById-System-Collections-Generic-IEnumerable{`1}- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.DeleteRangeById(System.Collections.Generic.IEnumerable{`1})')
  - [Filter(query,filter)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-Filter-System-Linq-IQueryable{`0},WebApi-Software-Utility-Repository-Interface-IFilter- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.Filter(System.Linq.IQueryable{`0},WebApi.Software.Utility.Repository.Interface.IFilter)')
  - [Read()](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-Read 'WebApi.Software.Utility.Repository.Interface.IRepository`2.Read')
  - [ReadById(id)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-ReadById-`1- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.ReadById(`1)')
  - [ReadByIdAsync(id)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-ReadByIdAsync-`1- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.ReadByIdAsync(`1)')
  - [Update(entity)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-Update-`0- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.Update(`0)')
  - [UpdateAsync(entity)](#M-WebApi-Software-Utility-Repository-Interface-IRepository`2-UpdateAsync-`0- 'WebApi.Software.Utility.Repository.Interface.IRepository`2.UpdateAsync(`0)')

<a name='T-WebApi-Software-Utility-Repository-Data-BaseRepository`2'></a>
## BaseRepository\`2 `type`

##### Namespace

WebApi.Software.Utility.Repository.Data

##### Summary

A generic repositiory pattern for apply basic C.R.U.D. (Create, Read, Update and Delete)
operations on a given entity.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The entity type that inhearits this class. |
| TKey | The entity primary key type that inhearits this class. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-#ctor-Microsoft-EntityFrameworkCore-DbContext-'></a>
### #ctor(dbContext) `constructor`

##### Summary

Constructor for building the base repository.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dbContext | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The DB Context for the Reposity. |

<a name='F-WebApi-Software-Utility-Repository-Data-BaseRepository`2-_dbContext'></a>
### _dbContext `constants`

##### Summary

The base DB Context for the Resposity.

<a name='F-WebApi-Software-Utility-Repository-Data-BaseRepository`2-_dbSet'></a>
### _dbSet `constants`

##### Summary

The DB Set to execute transactions against.

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-Create-`0-'></a>
### Create(entity) `method`

##### Summary

Creates a new entity associated to the Unit of Work.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`0](#T-`0 '`0') | The entity to create in the Unit of Work. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-CreateAsync-`0-'></a>
### CreateAsync(entity) `method`

##### Summary

Creates a new entity associated to the Unit of Work.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`0](#T-`0 '`0') | The entity to create in the Unit of Work. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-CreateRange-System-Collections-Generic-IEnumerable{`0}-'></a>
### CreateRange(entities) `method`

##### Summary

Creates new entities associated to the Unit of Work.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entities | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`0}') | A list of entities to create. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-CreateRangeAsync-System-Collections-Generic-IEnumerable{`0}-'></a>
### CreateRangeAsync(entities) `method`

##### Summary

Creates new entities associated to the Unit of Work.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entities | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`0}') | A list of entities to create. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-Delete-`0-'></a>
### Delete(entity) `method`

##### Summary

Deletes an entity..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`0](#T-`0 '`0') | The entity to delete. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-DeleteById-`1-'></a>
### DeleteById(id) `method`

##### Summary

Deletes an entity by ID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [\`1](#T-`1 '`1') | The ID of the entity to delete. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-DeleteRange-System-Collections-Generic-IEnumerable{`0}-'></a>
### DeleteRange(entities) `method`

##### Summary

Deletes an group of entities.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entities | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`0}') | A list of entities to delete. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-DeleteRangeById-System-Collections-Generic-IEnumerable{`1}-'></a>
### DeleteRangeById(ids) `method`

##### Summary

Deletes a group of entities by ID's.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ids | [System.Collections.Generic.IEnumerable{\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`1}') | A list of entity ID's to delete. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-Filter-System-Linq-IQueryable{`0},WebApi-Software-Utility-Repository-Interface-IFilter-'></a>
### Filter(query,filter) `method`

##### Summary

Filters an existing entity by a page and a limit.

##### Returns

A filtered query.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.Linq.IQueryable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{`0}') | The queried entity list. |
| filter | [WebApi.Software.Utility.Repository.Interface.IFilter](#T-WebApi-Software-Utility-Repository-Interface-IFilter 'WebApi.Software.Utility.Repository.Interface.IFilter') | The filter to apply to the query. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-Read'></a>
### Read() `method`

##### Summary

Builds a query of all the available entities in the database.

##### Returns

A queryable list of entities.

##### Parameters

This method has no parameters.

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-ReadById-`1-'></a>
### ReadById(id) `method`

##### Summary

Reads a single entity from the database based on the entity ID.

##### Returns

The complete entity, if found, associated to the ID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [\`1](#T-`1 '`1') | The ID of the entity to read. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-ReadByIdAsync-`1-'></a>
### ReadByIdAsync(id) `method`

##### Summary

Reads a single entity from the database based on the entity ID.

##### Returns

The complete entity, if found, associated to the ID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [\`1](#T-`1 '`1') | The ID of the entity to read. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-Update-`0-'></a>
### Update(entity) `method`

##### Summary

Updates changes made to the entity in the database context.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`0](#T-`0 '`0') | The entity to update. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-UpdateAsync-`0-'></a>
### UpdateAsync(entity) `method`

##### Summary

Updates changes made to the entity in the database context.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`0](#T-`0 '`0') | The entity to update. |

<a name='M-WebApi-Software-Utility-Repository-Data-BaseRepository`2-getPrimaryKey-`0-'></a>
### getPrimaryKey(entity) `method`

##### Summary

Finds the primary key value within an entity.

##### Returns

The primary key value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`0](#T-`0 '`0') | The entity to find the primary key value of. |

<a name='T-WebApi-Software-Utility-Repository-Helper-DataHelper'></a>
## DataHelper `type`

##### Namespace

WebApi.Software.Utility.Repository.Helper

##### Summary

A static helper class to help with data objects.

<a name='M-WebApi-Software-Utility-Repository-Helper-DataHelper-CompareAndReplace``1-System-Object,System-Object-'></a>
### CompareAndReplace\`\`1(existingObject,newObject) `method`

##### Summary

Looks at an existing object and determines if it is different, if it is it replaces the
existing object with the new object.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| existingObject | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The current existing object to compare against. |
| newObject | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The new object that might have changes. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of object to compare. |

<a name='T-WebApi-Software-Utility-Repository-Abstract-FilterAbstract'></a>
## FilterAbstract `type`

##### Namespace

WebApi.Software.Utility.Repository.Abstract

##### Summary

A generic filter for database models.

<a name='P-WebApi-Software-Utility-Repository-Abstract-FilterAbstract-Limit'></a>
### Limit `property`

##### Summary

The amount or results to return on the filter.

<a name='P-WebApi-Software-Utility-Repository-Abstract-FilterAbstract-Page'></a>
### Page `property`

##### Summary

The page number to return on the filter.

<a name='M-WebApi-Software-Utility-Repository-Abstract-FilterAbstract-Clone'></a>
### Clone() `method`

##### Summary

Clones the existing filter in a new memory space.

##### Returns

A new copy of the filter.

##### Parameters

This method has no parameters.

<a name='M-WebApi-Software-Utility-Repository-Abstract-FilterAbstract-Clone-System-Int32-'></a>
### Clone(page) `method`

##### Summary

Returns a clone +/- the page number of the original filter.

##### Returns

The filter +/- the page number.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The amount you want to up or down the filter page. |

<a name='T-WebApi-Software-Utility-Repository-Poco-FilterPoco'></a>
## FilterPoco `type`

##### Namespace

WebApi.Software.Utility.Repository.Poco

##### Summary

Specialized filter adding the ability to filter Planets by Planet Size, Minimum Equatorial
Diameter and Maximum Diameter.

<a name='M-WebApi-Software-Utility-Repository-Poco-FilterPoco-Clone'></a>
### Clone() `method`

##### Summary

Creates a clone of this filter with the same parameters.

##### Returns

PlanetFilterPoco

##### Parameters

This method has no parameters.

<a name='M-WebApi-Software-Utility-Repository-Poco-FilterPoco-Clone-System-Int32-'></a>
### Clone(page) `method`

##### Summary

Creates a clone of this filter changing the paging parameters to the page number.

##### Returns

PlanetFilterPoco

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The page number to clone too. |

<a name='T-WebApi-Software-Utility-Repository-Interface-IFilter'></a>
## IFilter `type`

##### Namespace

WebApi.Software.Utility.Repository.Interface

##### Summary

A generic filter to apply to entities.

<a name='P-WebApi-Software-Utility-Repository-Interface-IFilter-Limit'></a>
### Limit `property`

##### Summary

The amount or results to return on the filter.

<a name='P-WebApi-Software-Utility-Repository-Interface-IFilter-Page'></a>
### Page `property`

##### Summary

The page number to return on the filter.

<a name='M-WebApi-Software-Utility-Repository-Interface-IFilter-Clone'></a>
### Clone() `method`

##### Summary

Clones the existing filter in a new memory space.

##### Returns

A new copy of the filter.

##### Parameters

This method has no parameters.

<a name='M-WebApi-Software-Utility-Repository-Interface-IFilter-Clone-System-Int32-'></a>
### Clone(page) `method`

##### Summary

Returns a clone +/- the page number of the original filter.

##### Returns

The filter +/- the page number.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The amount you want to up or down the filter page. |

<a name='T-WebApi-Software-Utility-Repository-Interface-IRepository`2'></a>
## IRepository\`2 `type`

##### Namespace

WebApi.Software.Utility.Repository.Interface

##### Summary

A generic repositiory pattern for apply basic C.R.U.D. (Create, Read, Update and Delete)
operations on a given entity.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The entity type that inhearits this class. |
| TKey | The entity primary key type that inhearits this class. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-Create-`0-'></a>
### Create(entity) `method`

##### Summary

Creates a new entity associated to the Unit of Work.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`0](#T-`0 '`0') | The entity to create in the Unit of Work. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-CreateAsync-`0-'></a>
### CreateAsync(entity) `method`

##### Summary

Creates a new entity associated to the Unit of Work.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`0](#T-`0 '`0') | The entity to create in the Unit of Work. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-CreateRange-System-Collections-Generic-IEnumerable{`0}-'></a>
### CreateRange(entities) `method`

##### Summary

Creates new entities associated to the Unit of Work.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entities | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`0}') | A list of entities to create. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-CreateRangeAsync-System-Collections-Generic-IEnumerable{`0}-'></a>
### CreateRangeAsync(entities) `method`

##### Summary

Creates new entities associated to the Unit of Work.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entities | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`0}') | A list of entities to create. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-Delete-`0-'></a>
### Delete(entity) `method`

##### Summary

Deletes an entity..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`0](#T-`0 '`0') | The entity to delete. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-DeleteById-`1-'></a>
### DeleteById(id) `method`

##### Summary

Deletes an entity by ID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [\`1](#T-`1 '`1') | The ID of the entity to delete. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-DeleteRange-System-Collections-Generic-IEnumerable{`0}-'></a>
### DeleteRange(entities) `method`

##### Summary

Deletes an group of entities.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entities | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`0}') | A list of entities to delete. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-DeleteRangeById-System-Collections-Generic-IEnumerable{`1}-'></a>
### DeleteRangeById(ids) `method`

##### Summary

Deletes a group of entities by ID's.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ids | [System.Collections.Generic.IEnumerable{\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`1}') | A list of entity ID's to delete. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-Filter-System-Linq-IQueryable{`0},WebApi-Software-Utility-Repository-Interface-IFilter-'></a>
### Filter(query,filter) `method`

##### Summary

Filters an existing entity by a page and a limit.

##### Returns

A filtered query.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.Linq.IQueryable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{`0}') | The queried entity list. |
| filter | [WebApi.Software.Utility.Repository.Interface.IFilter](#T-WebApi-Software-Utility-Repository-Interface-IFilter 'WebApi.Software.Utility.Repository.Interface.IFilter') | The filter to apply to the query. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-Read'></a>
### Read() `method`

##### Summary

Builds a query of all the available entities in the database.

##### Returns

A queryable list of entities.

##### Parameters

This method has no parameters.

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-ReadById-`1-'></a>
### ReadById(id) `method`

##### Summary

Reads a single entity from the database based on the entity ID.

##### Returns

The complete entity, if found, associated to the ID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [\`1](#T-`1 '`1') | The ID of the entity to read. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-ReadByIdAsync-`1-'></a>
### ReadByIdAsync(id) `method`

##### Summary

Reads a single entity from the database based on the entity ID.

##### Returns

The complete entity, if found, associated to the ID.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [\`1](#T-`1 '`1') | The ID of the entity to read. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-Update-`0-'></a>
### Update(entity) `method`

##### Summary

Updates changes made to the entity in the database context.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`0](#T-`0 '`0') | The entity to update. |

<a name='M-WebApi-Software-Utility-Repository-Interface-IRepository`2-UpdateAsync-`0-'></a>
### UpdateAsync(entity) `method`

##### Summary

Updates changes made to the entity in the database context.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`0](#T-`0 '`0') | The entity to update. |
