using OpenPath.Standard.Base.Data.Database;
using OpenPath.Standard.Base.Data.Poco;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Service.Interface {

    public interface IPlanetService {

        Task<PlanetModel> AddAsync(PlanetModel planet);

        Task<IEnumerable<PlanetModel>> ListAsync(PlanetFilterPoco filter);

    }

}
