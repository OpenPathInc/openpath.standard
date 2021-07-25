using OpenPath.Standard.Base.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPath.Standard.Base.Repository.Interface {

    public interface IRepository<TEntity, TKey> where TEntity : class {

        TEntity GetById(TKey id);

        Task<TEntity> GetByIdAsync(TKey id);

        IQueryable<TEntity> List();

        IQueryable<TEntity> Filter(IQueryable<TEntity> query, IFilter filter);

        void Add(TEntity entity);

        Task AddAsync(TEntity entity);

    }

}
