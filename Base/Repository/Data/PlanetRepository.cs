using Microsoft.EntityFrameworkCore;
using WebApi.Software.Standard.Base.Data.Database;
using WebApi.Software.Standard.Base.Repository.Interface;
using WebApi.Software.Utility.Repository.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Software.Standard.Base.Repository.Data {

    /// <inheritdoc />
    /// <summary>
    /// The class for accessing Planet based data.
    /// </summary>
    public class PlanetRepository : BaseRepository<PlanetModel, long>, IPlanet {

        // CONSTRUCTORS
        // ====================================================================================================

        /// <summary>
        /// The Planet Repository for accessing Planet data in the database.
        /// </summary>
        /// <param name="standardDbContext">The database context that contains the Planet data.</param>
        public PlanetRepository(StandardDbContext standardDbContext) : base(standardDbContext) { }



        // METHODS
        // ====================================================================================================

        /// <summary>
        /// Checks if the Planet name Key already exists in the database.
        /// </summary>
        /// <param name="key">A Planet Key</param>
        /// <returns>Returns True if the Key exist, False if it does not exist.</returns>
        public IQueryable<PlanetModel> ListByEquatorialDiameter(double? minimum, double? maximum) {

            // validate the data, set to min and max is null
            if (minimum == null) minimum = double.MinValue;
            if (maximum == null) maximum = double.MaxValue;

            // build the query
            var query = Read()
                .Where(
                    _ =>
                    _.EquatorialDiameter >= minimum &&
                    _.EquatorialDiameter <= maximum
                );

            // return the query
            return query;

        }

        /// <summary>
        /// Looks up a Planet by the Planet Key.
        /// </summary>
        /// <param name="key">The Planet Key to look up the Planet by.</param>
        /// <returns>Returns a Planet.</returns>
        public async Task<bool> KeyExistsAsync(string key) {

            // look up only the key to see if it exists
            var result = await Read()
                .Where(_ => _.Key == key)
                .Select(_ => _.Key)
                .FirstOrDefaultAsync();

            // check if it exists
            var exists = result != null;

            // return if they key exists
            return exists;

        }

        /// <summary>
        /// Looks up a Planet by the Planet Key.
        /// </summary>
        /// <param name="key">The Planet Key to look up the Planet by.</param>
        /// <returns>Returns a Planet.</returns>
        public async Task<PlanetModel> ReadByKeyAsync(string key) {

            // look up the planet by the key
            var result = await Read()
                .Where(_ => _.Key == key)
                .FirstOrDefaultAsync();

            // return the result of the lookup
            return result;

        }

        /// <summary>
        /// Deletes a Planet by the Planet Key.
        /// </summary>
        /// <param name="key">The Planet Key to Detele the Planet by.</param>
        public void DeleteByKey(string key) {

            // find the planet by the key
            var entity = Read()
                .Where(_ => _.Key == key)
                .FirstOrDefault();

            // if the entity was found detete it
            if (entity != null) Delete(entity);

        }

        /// <summary>
        /// Deletes a Planet by the Planet Key.
        /// </summary>
        /// <param name="key">The Planet Key to Detele the Planet by.</param>
        public async Task DeleteByKeyAsync(string key) {

            // find the planet by the key
            var entity = await ReadByKeyAsync(key);

            // if the entity was found detete it
            if (entity != null) Delete(entity);

        }

    }

}
