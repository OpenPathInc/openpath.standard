using OpenPath.Standard.Base.Data.Database;
using OpenPath.Utility.Repository.Interface;
using System.Linq;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Repository.Interface {

    public interface IPlanet : IRepository<PlanetModel, long> {

        IQueryable<PlanetModel> ListByEquatorialDiameter(double? minimum, double? maximum);

        Task<bool> KeyExistsAsync(string key);

        Task<PlanetModel> ReadByKeyAsync(string key);

        void DeleteByKey(string key);

        Task DeleteByKeyAsync(string key);

    }

}
