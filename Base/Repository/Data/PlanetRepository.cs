using OpenPath.Standard.Base.Data.Database;
using OpenPath.Standard.Base.Repository.Interface;
using OpenPath.Utility.Repository.Data;
using System.Linq;

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

    }
}
