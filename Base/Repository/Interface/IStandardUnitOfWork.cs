using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Repository.Interface {

    public interface IStandardUnitOfWork {

        IStandardDbContext DbContext { get; }

        IPlanet Planets { get; }

        int Commit();

        Task<int> CommitAsync();

    }

}
