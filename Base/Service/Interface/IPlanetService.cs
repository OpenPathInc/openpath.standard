using OpenPath.Standard.Base.Data.Database;
using OpenPath.Standard.Base.Data.Poco;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Service.Interface {

    /// <summary>
    /// Service to Manage Planets.
    /// </summary>
    public interface IPlanetService {

        /// <summary>
        /// This method will add or update the Planet passed to it. If the Planet already has a
        /// Planet ID that is greater than zero (0) then the method will lookup and update the
        /// exist Planet, if the Planet ID is less than or equal to zero (0), then it will add the
        /// Planet.
        /// </summary>
        /// <param name="planet">The Planet to Add or Update.</param>
        Task AddUpdateAsync(PlanetModel planet);

        /// <summary>
        /// This method will add or update an array of Planets passed to it. The Planets will be
        /// sorted by what needs to be added or updated based on the following parameters: If the
        /// Planet already has a Planet ID that is greater than zero (0) then the method will
        /// lookup and update the exist Planet, if the Planet ID is less than or equal to zero (0),
        /// then it will add the Planet.
        /// </summary>
        /// <param name="planet">The Planet to Add or Update.</param>
        Task AddUpdateAsync(IEnumerable<PlanetModel> planets);

        /// <summary>
        /// Returns a paged list of Planets based on the filter and the maximum amount of items
        /// allowed per page.
        /// </summary>
        /// <param name="filter">The filter(s) to apply to this list.</param>
        Task<IEnumerable<PlanetModel>> ListAsync(PlanetFilterPoco filter);

        /// <summary>
        /// Remove a Planet by the Planet ID.
        /// </summary>
        /// <param name="id">The ID of the Planet.</param>
        Task RemoveAsync(long id);

        /// <summary>
        /// Remove a Planet by the Planet Key.
        /// </summary>
        /// <param name="id">The Key of the Planet.</param>
        Task RemoveAsync(string key);

        /// <summary>
        /// Get a Planet by the Planet ID.
        /// </summary>
        /// <param name="id">The ID of the Planet.</param>
        /// <returns>A Planet associated to the ID.</returns>
        Task<PlanetModel> GetAsync(long id);

        /// <summary>
        /// Get a Planet by the Planet Key.
        /// </summary>
        /// <param name="id">The Key of the Planet.</param>
        /// <returns>A Planet associated to the Key.</returns>
        Task<PlanetModel> GetAsync(string key);

    }

}
