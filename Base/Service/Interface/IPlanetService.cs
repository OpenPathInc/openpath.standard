using OpenPath.Standard.Base.Data.Database;
using OpenPath.Standard.Base.Data.Poco;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Service.Interface {

    public interface IPlanetService {

        Task AddAsync(PlanetModel planet);

        Task AddAsync(IEnumerable<PlanetModel> planets);

        Task<IEnumerable<PlanetModel>> ListAsync(PlanetFilterPoco filter);

        Task RemoveAsync(long id);

    }

}
