using Microsoft.EntityFrameworkCore;
using OpenPath.Standard.Base.Data.Database;
using OpenPath.Standard.Base.Repository.Interface;
using OpenPath.Utility.Repository.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Repository.Data {

    public class PlanetRepository : BaseRepository<PlanetModel, long>, IPlanet {

        public PlanetRepository(StandardDbContext standardDbContext) : base(standardDbContext) { }

        public IQueryable<PlanetModel> ListByEquatorialDiameter(double? minimum, double? maximum) {

            // validate
            if (minimum == null) minimum = double.MinValue;
            if (maximum == null) maximum = double.MaxValue;

            // build and return query
            var query = Read()
                .Where(
                    _ =>
                    _.EquatorialDiameter >= minimum &&
                    _.EquatorialDiameter <= maximum
                );

            return query;

        }

        public async Task<bool> KeyExistsAsync(string key) {

            var result = await Read()
                .Where(_ => _.Key == key)
                .Select(_ => _.Key)
                .FirstOrDefaultAsync();

            return result != null;

        }

        public async Task<PlanetModel> ReadByKeyAsync(string key) {

            var result = await Read()
                .Where(_ => _.Key == key)
                .FirstOrDefaultAsync();

            return result;

        }

        public void DeleteByKey(string key) {

            var entity = Read()
                .Where(_ => _.Key == key)
                .FirstOrDefault();

            Delete(entity);

        }

        public async Task DeleteByKeyAsync(string key) {

            var entity = await ReadByKeyAsync(key);

            Delete(entity);

        }
    }

}
