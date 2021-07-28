﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenPath.Utility.Repository.Interface {

    public interface IRepository<TEntity, TKey> where TEntity : class {

        void Add(TEntity entity);

        Task AddAsync(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        TEntity GetById(TKey id);

        Task<TEntity> GetByIdAsync(TKey id);

        IQueryable<TEntity> List();

        IQueryable<TEntity> Filter(IQueryable<TEntity> query, IFilter filter);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);

        void RemoveById(TKey id);

        void RemoveRangeById(IEnumerable<TKey> ids);

    }

}
