using OpenPath.Standard.Base.Data.Database;
using OpenPath.Standard.Base.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Repository.Data {

    public class PlanetRepository : BaseRepository<PlanetModel, long>, IPlanet {

        public PlanetRepository(StandardDbContext standardDbContext) : base(standardDbContext) { }

        public IQueryable<PlanetModel> ListByEquatorialDiameter(double? minimum, double? maximum) {

            // validate
            if (minimum == null) minimum = double.MinValue;
            if (maximum == null) maximum = double.MaxValue;

            // build and return query
            var query = List()
                .Where(
                    _ =>
                    _.EquatorialDiameter >= minimum &&
                    _.EquatorialDiameter <= maximum
                );

            return query;

        }

    }
}
