using Microsoft.EntityFrameworkCore;
using WebApi.Software.Standard.Base.Data.Database;
using WebApi.Software.Standard.Base.Data.Poco;
using WebApi.Software.Standard.Base.Repository.Interface;
using WebApi.Software.Standard.Base.Service.Interface;
using OpenPath.Utility.Parser;
using WebApi.Software.Utility.Repository.Helper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Software.Standard.Base.Service {

    /// <summary>
    /// The base service class for calling planets and all the subsets of data from each planet.
    /// </summary>
    public class PlanetService : IPlanetService {

        // CONSTANTS
        // ====================================================================================================

        /// <summary>
        /// The maximum size of a planet that is small.
        /// </summary>
        public const double SMALL_PLANET_MAXIMUM = 19999.9999999999;

        /// <summary>
        /// The mimimum size of a medimum sized planet.
        /// </summary>
        public const double MEDIUM_PLANET_MINIMUM = 20000;

        /// <summary>
        /// The maximum size of a medimum sized planet.
        /// </summary>
        public const double MEDIUM_PLANET_MAXIMUM = 99999.9999999999;

        /// <summary>
        /// The minimum size of a large planet.
        /// </summary>
        public const double LARGE_PLANET_MINIMUM = 100000;



        // MEMBERS
        // ====================================================================================================

        /// <summary>
        /// The injected unit of work for the data where the planet exists.
        /// </summary>
        protected readonly IStandardUnitOfWork _standardUnitOfWork;



        // CONSTRUCTORS
        // ====================================================================================================

        /// <summary>
        /// The injectable constructor for the planet service that connects the service to the
        /// database.
        /// </summary>
        /// <param name="standardUnitOfWork">The unit of work for Planets.</param>
        public PlanetService(IStandardUnitOfWork standardUnitOfWork) {

            _standardUnitOfWork = standardUnitOfWork;

        }



        // METHODS
        // ====================================================================================================

        /// <summary>
        /// This method will add or update the Planet passed to it. If the Planet already has a
        /// Planet ID that is greater than zero (0) then the method will lookup and update the
        /// exist Planet, if the Planet ID is less than or equal to zero (0), then it will add the
        /// Planet.
        /// </summary>
        /// <param name="planet">The Planet to Add or Update.</param>
        public async Task<ServiceResponsePaco> AddUpdateAsync(PlanetModel planet) {

            // validate request
            if (planet == null) throw new System.ArgumentNullException("Planet", "Planet object cannot be null");

            // create list to pass to the other method
            var planetList = new List<PlanetModel>() { planet };

            //planetList.Add(planet);

            return await AddUpdateAsync(planetList);

            //// determine if this is an update or add
            //var add = planet.Id <= 0;

            //// reguardless of update or add, make sure the key is correct
            //planet.Key = await generateKeyAsync(planet.Name, planet.Id <= 0);

            //// if this is an add then add
            //if (add) {

            //    // create a new planet
            //    await _standardUnitOfWork.Planets.CreateAsync(planet);

            //}
            //// if this is an update then look up and update
            //else {

            //    // look up the existing planet
            //    var currentPlanet = await _standardUnitOfWork.Planets.ReadByIdAsync(planet.Id);

            //    // check the looked up and existing planets and update only if any of the values
            //    // have changed
            //    updateChanged(currentPlanet, planet);

            //}

            //// commit if any changes to the database and record the amount of rows updated as a
            //// sanity check
            //var rowsUpdated = await _standardUnitOfWork.CommitAsync();

        }

        /// <summary>
        /// This method will add or update an array of Planets passed to it. The Planets will be
        /// sorted by what needs to be added or updated based on the following parameters: If the
        /// Planet already has a Planet ID that is greater than zero (0) then the method will
        /// lookup and update the exist Planet, if the Planet ID is less than or equal to zero (0),
        /// then it will add the Planet.
        /// </summary>
        /// <param name="planets">The Planets to Add or Update.</param>
        public async Task<ServiceResponsePaco> AddUpdateAsync(IEnumerable<PlanetModel> planets) {

            // create the service response
            var serviceResponse = new ServiceResponsePaco();

            // update the planet key for every planet reguardless of add or update
            foreach (var planet in planets) {

                // generate the proper name key
                planet.Key = await generateKeyAsync(planet.Name, planet.Id <= 0);

            }

            // create a list of the planets we need to add
            var addPlanets = planets.Where(planet => planet.Id <= 0);

            // crate a list of the planets we are going to update
            var updatePlanets = planets.Where(planet => planet.Id > 0);

            // if there are planets to add then add them
            if (addPlanets != null && addPlanets.Count() > 0) {

                // add the planets
                await _standardUnitOfWork.Planets.CreateRangeAsync(addPlanets);

            }

            // if there are planets to update then see if we need to update them
            if (updatePlanets != null && updatePlanets.Count() > 0) {

                // look up each planet and check if they need to be updated
                foreach (var planet in updatePlanets) {

                    // look up the planet
                    var currentPlanet = await _standardUnitOfWork.Planets.ReadByIdAsync(planet.Id);

                    // check what needs to be update
                    updateChanged(currentPlanet, planet);

                }

            }

            // record the number of records updated on the commit
            serviceResponse.RecordsUpdated = await _standardUnitOfWork.CommitAsync();

            // update the additional details of the serviceResponse
            serviceResponse.CreatedIds = (addPlanets != null && addPlanets.Count() > 0) ? addPlanets.Select(_ => _.Id) : null;
            serviceResponse.UpdatedIds = (updatePlanets != null && updatePlanets.Count() > 0) ? updatePlanets.Select(_ => _.Id) : null;

            // return the service response
            return serviceResponse;

        }

        /// <summary>
        /// Returns a paged list of Planets based on the filter and the maximum amount of items
        /// allowed per page.
        /// </summary>
        /// <param name="filter">The filter(s) to apply to this list.</param>
        public async Task<IEnumerable<PlanetModel>> ListAsync(PlanetFilterPoco filter) {

            // validation
            if (filter == null) return null;
            if (filter.Page == 0) return null;
            if (filter.Limit == 0) return null;

            // build query
            var planetsQuery = _standardUnitOfWork.Planets.Read();

            // add custom filters
            if (filter.PlanetSize != null) {

                // based on the planet size apply the correct diameter filter
                switch (filter.PlanetSize) {

                    // filter for small planets
                    case Data.Enumerator.PlanetSizeEnum.Small:
                        filter.EquatorialDiameterMinimum = null;
                        filter.EquatorialDiameterMaximum = SMALL_PLANET_MAXIMUM;
                        break;

                    // filter for medium planets
                    case Data.Enumerator.PlanetSizeEnum.Medium:
                        filter.EquatorialDiameterMinimum = MEDIUM_PLANET_MINIMUM;
                        filter.EquatorialDiameterMaximum = MEDIUM_PLANET_MAXIMUM;
                        break;

                    // filter for large planets
                    case Data.Enumerator.PlanetSizeEnum.Large:
                        filter.EquatorialDiameterMinimum = LARGE_PLANET_MINIMUM;
                        filter.EquatorialDiameterMaximum = null;
                        break;

                }

            }

            // if diameter filter is apply apply the diameter
            if (filter.EquatorialDiameterMinimum != null || filter.EquatorialDiameterMaximum != null) {

                planetsQuery = _standardUnitOfWork.Planets
                    .ListByEquatorialDiameter(
                        filter.EquatorialDiameterMinimum,
                        filter.EquatorialDiameterMaximum
                    );

            }

            // apply the generic filtering logic  
            var filteredResults = await _standardUnitOfWork.Planets
                .Filter(planetsQuery, filter)
                .ToListAsync();

            // return the filtered results
            return filteredResults;

        }

        /// <summary>
        /// Get a Planet by the Planet ID.
        /// </summary>
        /// <param name="id">The ID of the Planet.</param>
        /// <returns>A Planet associated to the ID.</returns>
        public async Task<PlanetModel> GetAsync(long id) {

            // return the planet by id
            return await _standardUnitOfWork
                .Planets
                .ReadByIdAsync(id);

        }

        /// <summary>
        /// Get a Planet by the Planet Key.
        /// </summary>
        /// <param name="id">The Key of the Planet.</param>
        /// <returns>A Planet associated to the Key.</returns>
        public async Task<PlanetModel> GetAsync(string key) {

            // return the planet by key
            return await _standardUnitOfWork
                .Planets
                .ReadByKeyAsync(key);

        }

        /// <summary>
        /// Remove a Planet by the Planet ID.
        /// </summary>
        /// <param name="id">The ID of the Planet.</param>
        public async Task RemoveAsync(long id) {

            // delete the planet form the unit of work
            _standardUnitOfWork.Planets.DeleteById(id);

            // commit the unit of work
            var rowsUpdated = await _standardUnitOfWork.CommitAsync();

        }

        /// <summary>
        /// Remove a Planet by the Planet Key.
        /// </summary>
        /// <param name="id">The Key of the Planet.</param>
        public async Task RemoveAsync(string key) {

            // delete the planet form the unit of work
            await _standardUnitOfWork.Planets.DeleteByKeyAsync(key);

            // commit the unit of work
            var rowsUpdated = await _standardUnitOfWork.CommitAsync();

        }



        // HELPERS
        // ====================================================================================================

        /// <summary>
        /// Creates an URL cased version of the Planet name, if it already exists and the check if
        /// exists flag is not set then this method will throw a Duplicate Name Expection.
        /// </summary>
        /// <param name="name">The name of the Planet.</param>
        /// <param name="checkIfExists">
        /// If empty or true will throw a Duplicate Name Expection if
        /// the name exists.
        /// </param>
        /// <returns>The URL cased name.</returns>
        private async Task<string> generateKeyAsync(string name, bool checkIfExists) {

            // convert the name to a url case
            var key = name.ToUrlCase();

            // if check if exists check if the name exists and throw exception if does
            var keyExists = checkIfExists ? await _standardUnitOfWork.Planets.KeyExistsAsync(key) : false;

            // throw error if exists
            if (keyExists) throw new DuplicateNameException("Planet name already exists in the data.");

            // return url cased key
            return key;

        }

        /// <summary>
        /// Checks for changes between the updated Planet and original Planet and only updates the
        /// Planet if the values are different.
        /// </summary>
        /// <param name="originalPlanet">Original Planet.</param>
        /// <param name="updatedPlanet">Updated Planet.</param>
        private void updateChanged(PlanetModel originalPlanet, PlanetModel updatedPlanet) {

            // check each property and update only if different this will reduce database updates
            // if the updates are the same
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
