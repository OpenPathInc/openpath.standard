using OpenPath.Standard.Base.Data.Database;
using OpenPath.Utility.Repository.Interface;
using System.Linq;

namespace OpenPath.Standard.Base.Repository.Interface {

    public interface IPlanet : IRepository<PlanetModel, long> {

        IQueryable<PlanetModel> ListByEquatorialDiameter(double? minimum, double? maximum);

    }

}
