<a name='assembly'></a>
# WebApiSoftware-Standard-Data

## Contents

- [EnvelopePoco\`1](#T-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1 'WebApi.Software.Standard.Base.Data.Poco.EnvelopePoco`1')
  - [ApiName](#P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-ApiName 'WebApi.Software.Standard.Base.Data.Poco.EnvelopePoco`1.ApiName')
  - [Company](#P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-Company 'WebApi.Software.Standard.Base.Data.Poco.EnvelopePoco`1.Company')
  - [Copyright](#P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-Copyright 'WebApi.Software.Standard.Base.Data.Poco.EnvelopePoco`1.Copyright')
  - [CurrentPage](#P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-CurrentPage 'WebApi.Software.Standard.Base.Data.Poco.EnvelopePoco`1.CurrentPage')
  - [Data](#P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-Data 'WebApi.Software.Standard.Base.Data.Poco.EnvelopePoco`1.Data')
  - [Filter](#P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-Filter 'WebApi.Software.Standard.Base.Data.Poco.EnvelopePoco`1.Filter')
  - [LastPage](#P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-LastPage 'WebApi.Software.Standard.Base.Data.Poco.EnvelopePoco`1.LastPage')
  - [NextPage](#P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-NextPage 'WebApi.Software.Standard.Base.Data.Poco.EnvelopePoco`1.NextPage')
  - [Response](#P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-Response 'WebApi.Software.Standard.Base.Data.Poco.EnvelopePoco`1.Response')
  - [UtcTimestamp](#P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-UtcTimestamp 'WebApi.Software.Standard.Base.Data.Poco.EnvelopePoco`1.UtcTimestamp')
  - [Version](#P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-Version 'WebApi.Software.Standard.Base.Data.Poco.EnvelopePoco`1.Version')
- [PlanetFilterPoco](#T-WebApi-Software-Standard-Base-Data-Poco-PlanetFilterPoco 'WebApi.Software.Standard.Base.Data.Poco.PlanetFilterPoco')
  - [EquatorialDiameterMaximum](#P-WebApi-Software-Standard-Base-Data-Poco-PlanetFilterPoco-EquatorialDiameterMaximum 'WebApi.Software.Standard.Base.Data.Poco.PlanetFilterPoco.EquatorialDiameterMaximum')
  - [EquatorialDiameterMinimum](#P-WebApi-Software-Standard-Base-Data-Poco-PlanetFilterPoco-EquatorialDiameterMinimum 'WebApi.Software.Standard.Base.Data.Poco.PlanetFilterPoco.EquatorialDiameterMinimum')
  - [PlanetSize](#P-WebApi-Software-Standard-Base-Data-Poco-PlanetFilterPoco-PlanetSize 'WebApi.Software.Standard.Base.Data.Poco.PlanetFilterPoco.PlanetSize')
  - [Clone()](#M-WebApi-Software-Standard-Base-Data-Poco-PlanetFilterPoco-Clone 'WebApi.Software.Standard.Base.Data.Poco.PlanetFilterPoco.Clone')
  - [Clone(page)](#M-WebApi-Software-Standard-Base-Data-Poco-PlanetFilterPoco-Clone-System-Int32- 'WebApi.Software.Standard.Base.Data.Poco.PlanetFilterPoco.Clone(System.Int32)')
- [PlanetModel](#T-WebApi-Software-Standard-Base-Data-Database-PlanetModel 'WebApi.Software.Standard.Base.Data.Database.PlanetModel')
  - [Density](#P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-Density 'WebApi.Software.Standard.Base.Data.Database.PlanetModel.Density')
  - [DeviationFromF](#P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-DeviationFromF 'WebApi.Software.Standard.Base.Data.Database.PlanetModel.DeviationFromF')
  - [EquatorialBulge](#P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-EquatorialBulge 'WebApi.Software.Standard.Base.Data.Database.PlanetModel.EquatorialBulge')
  - [EquatorialDiameter](#P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-EquatorialDiameter 'WebApi.Software.Standard.Base.Data.Database.PlanetModel.EquatorialDiameter')
  - [F](#P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-F 'WebApi.Software.Standard.Base.Data.Database.PlanetModel.F')
  - [FlatteningRatio](#P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-FlatteningRatio 'WebApi.Software.Standard.Base.Data.Database.PlanetModel.FlatteningRatio')
  - [Id](#P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-Id 'WebApi.Software.Standard.Base.Data.Database.PlanetModel.Id')
  - [Key](#P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-Key 'WebApi.Software.Standard.Base.Data.Database.PlanetModel.Key')
  - [Name](#P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-Name 'WebApi.Software.Standard.Base.Data.Database.PlanetModel.Name')
  - [PolarDiameter](#P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-PolarDiameter 'WebApi.Software.Standard.Base.Data.Database.PlanetModel.PolarDiameter')
  - [RotationPeriod](#P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-RotationPeriod 'WebApi.Software.Standard.Base.Data.Database.PlanetModel.RotationPeriod')
- [PlanetSizeEnum](#T-WebApi-Software-Standard-Base-Data-Enumerator-PlanetSizeEnum 'WebApi.Software.Standard.Base.Data.Enumerator.PlanetSizeEnum')
  - [Large](#F-WebApi-Software-Standard-Base-Data-Enumerator-PlanetSizeEnum-Large 'WebApi.Software.Standard.Base.Data.Enumerator.PlanetSizeEnum.Large')
  - [Medium](#F-WebApi-Software-Standard-Base-Data-Enumerator-PlanetSizeEnum-Medium 'WebApi.Software.Standard.Base.Data.Enumerator.PlanetSizeEnum.Medium')
  - [Small](#F-WebApi-Software-Standard-Base-Data-Enumerator-PlanetSizeEnum-Small 'WebApi.Software.Standard.Base.Data.Enumerator.PlanetSizeEnum.Small')

<a name='T-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1'></a>
## EnvelopePoco\`1 `type`

##### Namespace

WebApi.Software.Standard.Base.Data.Poco

##### Summary

A structure for returning standardized data packets to a requesting service.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The data type outside the standardized data returned. |

<a name='P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-ApiName'></a>
### ApiName `property`

##### Summary

The name of this API.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-Company'></a>
### Company `property`

##### Summary

The name of the company supporting this API.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-Copyright'></a>
### Copyright `property`

##### Summary

The copyright of this API.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-CurrentPage'></a>
### CurrentPage `property`

##### Summary

This is the reference to the current page of data.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-Data'></a>
### Data `property`

##### Summary

The data model or list returned with or without children depending on the service
requested.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-Filter'></a>
### Filter `property`

##### Summary

Filter applied to REST query.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-LastPage'></a>
### LastPage `property`

##### Summary

If the returned data is in a different page than the first page of data, the reference
of the last set of data will be set here, if this is the first page, then this valud
will be null.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-NextPage'></a>
### NextPage `property`

##### Summary

If only a limited set of data was returned and more data exists, the reference of the
next set of data will be set here. Otherwise, if there is no more data, this value will
be null.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-Response'></a>
### Response `property`

##### Summary

Returns the response from this request, including errors if any.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-UtcTimestamp'></a>
### UtcTimestamp `property`

##### Summary

Records the response Timestamp of this envelope in UTC.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-EnvelopePoco`1-Version'></a>
### Version `property`

##### Summary

The version of this API.

<a name='T-WebApi-Software-Standard-Base-Data-Poco-PlanetFilterPoco'></a>
## PlanetFilterPoco `type`

##### Namespace

WebApi.Software.Standard.Base.Data.Poco

##### Summary

Specialized filter adding the ability to filter Planets by Planet Size, Minimum Equatorial
Diameter and Maximum Diameter.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-PlanetFilterPoco-EquatorialDiameterMaximum'></a>
### EquatorialDiameterMaximum `property`

##### Summary

Filter for minimum equatorial diameter.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-PlanetFilterPoco-EquatorialDiameterMinimum'></a>
### EquatorialDiameterMinimum `property`

##### Summary

Filter for minimum equatorial diameter.

<a name='P-WebApi-Software-Standard-Base-Data-Poco-PlanetFilterPoco-PlanetSize'></a>
### PlanetSize `property`

##### Summary

Filter for planet size.

<a name='M-WebApi-Software-Standard-Base-Data-Poco-PlanetFilterPoco-Clone'></a>
### Clone() `method`

##### Summary

Creates a clone of this filter with the same parameters.

##### Returns

PlanetFilterPoco

##### Parameters

This method has no parameters.

<a name='M-WebApi-Software-Standard-Base-Data-Poco-PlanetFilterPoco-Clone-System-Int32-'></a>
### Clone(page) `method`

##### Summary

Creates a clone of this filter changing the paging parameters to the page number.

##### Returns

PlanetFilterPoco

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The page number to clone too. |

<a name='T-WebApi-Software-Standard-Base-Data-Database-PlanetModel'></a>
## PlanetModel `type`

##### Namespace

WebApi.Software.Standard.Base.Data.Database

##### Summary

Represents a planet in our solar system.

<a name='P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-Density'></a>
### Density `property`

##### Summary

The planet density is defined as the ratio of the mass of a planet to the volume of
space the planet takes up.

<a name='P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-DeviationFromF'></a>
### DeviationFromF `property`

##### Summary

The deviation from Flattenting.

<a name='P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-EquatorialBulge'></a>
### EquatorialBulge `property`

##### Summary

The equatorial bulge is a difference between the equatorial and polar diameters of a
planet, due to the centrifugal force exerted by the rotation about the body's axis.
A rotating body tends to form an oblate spheroid rather than a sphere.

<a name='P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-EquatorialDiameter'></a>
### EquatorialDiameter `property`

##### Summary

The diameter of the planet at its equator.

<a name='P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-F'></a>
### F `property`

##### Summary

f = Flattening which is a measure of the compression of a circle or sphere along a
diameter to form an ellipse or an ellipsoid of revolution (spheroid) respectively.

<a name='P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-FlatteningRatio'></a>
### FlatteningRatio `property`

##### Summary

The flattening ratio is a measure of how much an oblate spheroid differs from a sphere.
The flattening equals the ratio of the semimajor axis minus the semiminor axis to the
semimajor axis.

<a name='P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-Id'></a>
### Id `property`

##### Summary

A unique planet ID in the database.

<a name='P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-Key'></a>
### Key `property`

##### Summary

A unique text key that has a 1 to 1 relationship to the planet ID based off the name of
the planet.

<a name='P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-Name'></a>
### Name `property`

##### Summary

The english name for this planet.

<a name='P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-PolarDiameter'></a>
### PolarDiameter `property`

##### Summary

The diameter of a planet measured from pole to pole.

<a name='P-WebApi-Software-Standard-Base-Data-Database-PlanetModel-RotationPeriod'></a>
### RotationPeriod `property`

##### Summary

The rotation period of a celestial object (e.g., star, gas giant, planet, moon,
asteroid) is as its sidereal rotation period the time that the object takes to complete
a single revolution around its axis of rotation relative to the background stars,
measured in sidereal time. This type of rotation period differs from the object's
synodic rotation period (a solar day), measured in solar time, which may differ by a
fractional or multiple rotation to accommodate the portion of the object's orbital
period during one day.

<a name='T-WebApi-Software-Standard-Base-Data-Enumerator-PlanetSizeEnum'></a>
## PlanetSizeEnum `type`

##### Namespace

WebApi.Software.Standard.Base.Data.Enumerator

##### Summary

Basic set of Planet sizes.

<a name='F-WebApi-Software-Standard-Base-Data-Enumerator-PlanetSizeEnum-Large'></a>
### Large `constants`

##### Summary

A large panet.

<a name='F-WebApi-Software-Standard-Base-Data-Enumerator-PlanetSizeEnum-Medium'></a>
### Medium `constants`

##### Summary

A medium sized planet.

<a name='F-WebApi-Software-Standard-Base-Data-Enumerator-PlanetSizeEnum-Small'></a>
### Small `constants`

##### Summary

A small planet.
