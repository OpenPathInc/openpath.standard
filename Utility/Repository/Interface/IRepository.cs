using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenPath.Utility.Repository.Interface {

    public interface IRepository<TEntity, TKey> where TEntity : class {

        void Create(TEntity entity);

        Task CreateAsync(TEntity entity);

        void CreateRange(IEnumerable<TEntity> entities);

        Task CreateRangeAsync(IEnumerable<TEntity> entities);

        TEntity ReadById(TKey id);

        Task<TEntity> ReadByIdAsync(TKey id);

        IQueryable<TEntity> Read();

        IQueryable<TEntity> Filter(IQueryable<TEntity> query, IFilter filter);

        void Delete(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entities);

        void DeleteById(TKey id);

        void DeleteRangeById(IEnumerable<TKey> ids);

    }

}
