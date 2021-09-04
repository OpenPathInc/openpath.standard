using Microsoft.EntityFrameworkCore;
using OpenPath.Standard.Base.Data.Database;
using OpenPath.Standard.Base.Data.Poco;
using OpenPath.Standard.Base.Repository.Interface;
using OpenPath.Standard.Base.Service.Interface;
using OpenPath.Utility.Parser;
using OpenPath.Utility.Repository.Helper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public async Task AddUpdateAsync(PlanetModel planet) {

            if (planet == null) throw new System.ArgumentNullException("Planet", "Planet object cannot be null");

            var add = planet.Id <= 0;

            planet.Key = await generateKeyAsync(planet.Name, planet.Id <= 0);

            if(add) {

                await _standardUnitOfWork.Planets.CreateAsync(planet);

            }
            else {

                var currentPlanet = await _standardUnitOfWork.Planets.ReadByIdAsync(planet.Id);

                updateChanged(currentPlanet, planet);

            }            

            var rowsUpdated = await _standardUnitOfWork.CommitAsync();

        }

        public async Task AddUpdateAsync(IEnumerable<PlanetModel> planets) {

            foreach(var planet in planets) {

                planet.Key = await generateKeyAsync(planet.Name, planet.Id <= 0);

            }

            var addPlanets = planets.Where(planet => planet.Id <= 0);
            var updatePlanets = planets.Where(planet => planet.Id > 0);

            if (addPlanets != null && addPlanets.Count() > 0) {

                await _standardUnitOfWork.Planets.CreateRangeAsync(planets);

            }

            if (updatePlanets != null && updatePlanets.Count() > 0) {

                foreach(var planet in updatePlanets) {

                    var currentPlanet = await _standardUnitOfWork.Planets.ReadByIdAsync(planet.Id);

                    updateChanged(currentPlanet, planet);

                }

            }

            var rowsUpdated = await _standardUnitOfWork.CommitAsync();

        }

        public async Task<IEnumerable<PlanetModel>> ListAsync(PlanetFilterPoco filter) {

            // validation
            if (filter == null) return null;
            if (filter.Page == 0) return null;
            if (filter.Limit == 0) return null;

            // build query
            var planetsQuery = _standardUnitOfWork.Planets.Read();

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

        public async Task<PlanetModel> GetAsync(long id) {

            return await _standardUnitOfWork
                .Planets
                .ReadByIdAsync(id);

        }

        public async Task<PlanetModel> GetAsync(string key) {

            return await _standardUnitOfWork
                .Planets
                .ReadByKeyAsync(key);

        }

        public async Task RemoveAsync(long id) {

            _standardUnitOfWork.Planets.DeleteById(id);

            var rowsUpdated = await _standardUnitOfWork.CommitAsync();

        }

        public async Task RemoveAsync(string key) {

            await _standardUnitOfWork.Planets.DeleteByKeyAsync(key);

            var rowsUpdated = await _standardUnitOfWork.CommitAsync();

        }

        private async Task<string> generateKeyAsync(string name, bool checkIfExists) {

            var key = name.ToUrlCase();
            var keyExists = checkIfExists ? await _standardUnitOfWork.Planets.KeyExistsAsync(key) : false;

            if (keyExists) throw new DuplicateNameException("Planet name already exists in the data.");

            return key;
            
        }

        private void updateChanged(PlanetModel originalPlanet, PlanetModel updatedPlanet) {

            originalPlanet.Key = DataHelper.CompareAndReplace<string>(originalPlanet.Key, updatedPlanet.Key);
            originalPlanet.Density = DataHelper.CompareAndReplace<double>(originalPlanet.Density, updatedPlanet.Density);
            originalPlanet.DeviationFromF = DataHelper.CompareAndReplace<int>(originalPlanet.DeviationFromF, updatedPlanet.DeviationFromF);
            originalPlanet.EquatorialDiameter = DataHelper.CompareAndReplace<double>(originalPlanet.EquatorialDiameter, updatedPlanet.EquatorialDiameter);
            originalPlanet.F = DataHelper.CompareAndReplace<double>(originalPlanet.F, updatedPlanet.F);
            originalPlanet.FlatteningRatio = DataHelper.CompareAndReplace<double>(originalPlanet.FlatteningRatio, updatedPlanet.FlatteningRatio);
            originalPlanet.Name = DataHelper.CompareAndReplace<string>(originalPlanet.Name, updatedPlanet.Name);
            originalPlanet.PolarDiameter = DataHelper.CompareAndReplace<double>(originalPlanet.PolarDiameter, updatedPlanet.PolarDiameter);
            originalPlanet.RotationPeriod = DataHelper.CompareAndReplace<double>(originalPlanet.RotationPeriod, updatedPlanet.RotationPeriod);

        }

    }

}
