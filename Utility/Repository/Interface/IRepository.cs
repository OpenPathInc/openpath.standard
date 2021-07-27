using System.Linq;
using System.Threading.Tasks;

namespace OpenPath.Utility.Repository.Interface {

    public interface IRepository<TEntity, TKey> where TEntity : class {

        TEntity GetById(TKey id);

        Task<TEntity> GetByIdAsync(TKey id);

        IQueryable<TEntity> List();

        IQueryable<TEntity> Filter(IQueryable<TEntity> query, IFilter filter);

        void Add(TEntity entity);

        Task AddAsync(TEntity entity);

    }

}
