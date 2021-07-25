using OpenPath.Standard.Base.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Repository.Interface {

    public interface IPlanet : IRepository<PlanetModel, long> {

        IQueryable<PlanetModel> ListByEquatorialDiameter(double? minimum, double? maximum);

    }

}
