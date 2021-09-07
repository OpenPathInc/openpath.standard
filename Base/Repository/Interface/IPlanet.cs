using OpenPath.Standard.Base.Data.Database;
using OpenPath.Utility.Repository.Interface;
using System.Linq;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Repository.Interface {

    /// <summary>
    /// The Interface for accessing Planet based data.
    /// </summary>
    public interface IPlanet : IRepository<PlanetModel, long> {

        /// <summary>
        /// Lists all planets between a minimum equatorial diameter.
        /// </summary>
        /// <param name="minimum">The mimimum equatorial diameter of a planed in kilometers.</param>
        /// <param name="maximum">The maximum equatorial diameter of a planed in kilometers.</param>
        /// <returns>Returns an IQueryable list of Planets.</returns>
        IQueryable<PlanetModel> ListByEquatorialDiameter(double? minimum, double? maximum);

        /// <summary>
        /// Checks if the Planet name Key already exists in the database.
        /// </summary>
        /// <param name="key">A Planet Key</param>
        /// <returns>Returns True if the Key exist, False if it does not exist.</returns>
        Task<bool> KeyExistsAsync(string key);

        /// <summary>
        /// Looks up a Planet by the Planet Key.
        /// </summary>
        /// <param name="key">The Planet Key to look up the Planet by.</param>
        /// <returns>Returns a Planet.</returns>
        Task<PlanetModel> ReadByKeyAsync(string key);

        /// <summary>
        /// Deletes a Planet by the Planet Key.
        /// </summary>
        /// <param name="key">The Planet Key to Detele the Planet by.</param>
        void DeleteByKey(string key);

        /// <summary>
        /// Deletes a Planet by the Planet Key.
        /// </summary>
        /// <param name="key">The Planet Key to Detele the Planet by.</param>
        Task DeleteByKeyAsync(string key);

    }

}
