using Microsoft.EntityFrameworkCore;
using OpenPath.Standard.Base.Data.Database;
using OpenPath.Standard.Base.Data.Poco;
using OpenPath.Standard.Base.Repository.Interface;
using OpenPath.Standard.Base.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Service {

    public class PlanetService : IPlanetService {

        public const double SMALL_PLANET_MAXIMUM = 19999.9999999999;
        public const double MEDIUM_PLANET_MINIMUM = 20000;
        public const double MEDIUM_PLANET_MAXIMUM = 99999.9999999999;
        public const double LARGE_PLANET_MINIMUM = 100000;

        protected readonly IStandardUnitOfWork _standardUnitOfWork;

        public PlanetService(IStandardUnitOfWork standardUnitOfWork) {

            _standardUnitOfWork = standardUnitOfWork;

        }

        public async Task<IEnumerable<PlanetModel>> ListAsync(PlanetFilterPoco filter) {

            // validation
            if (filter == null) return null;
            if (filter.Page == 0) return null;
            if (filter.Limit == 0) return null;

            // build query
            var planetsQuery = _standardUnitOfWork.Planets.List();

            // add custom filters
            if (filter.PlanetSize != null) {

                switch (filter.PlanetSize) {

                    case Data.Enumerator.PlanetSizeEnum.Small:
                        filter.EquatorialDiameterMinimum = null;
                        filter.EquatorialDiameterMaximum = SMALL_PLANET_MAXIMUM;
                        break;

                    case Data.Enumerator.PlanetSizeEnum.Medium:
                        filter.EquatorialDiameterMinimum = MEDIUM_PLANET_MINIMUM;
                        filter.EquatorialDiameterMaximum = MEDIUM_PLANET_MAXIMUM;
                        break;

                    case Data.Enumerator.PlanetSizeEnum.Large:
                        filter.EquatorialDiameterMinimum = LARGE_PLANET_MINIMUM;
                        filter.EquatorialDiameterMaximum = null;
                        break;

                }

            }
            if (filter.EquatorialDiameterMinimum != null || filter.EquatorialDiameterMaximum != null) {

                planetsQuery = _standardUnitOfWork.Planets
                    .ListByEquatorialDiameter(
                        filter.EquatorialDiameterMinimum,
                        filter.EquatorialDiameterMaximum
                    );

            }

            // generic filtering logic  
            var filteredResults = await _standardUnitOfWork.Planets
                .Filter(planetsQuery, filter)
                .ToListAsync();

            return filteredResults;

        }

        public async Task<PlanetModel> AddAsync(PlanetModel planet) {

            await _standardUnitOfWork.Planets.AddAsync(planet);

            var rowsUpdated = await _standardUnitOfWork.CommitAsync();

            return planet;

        }

    }

}
