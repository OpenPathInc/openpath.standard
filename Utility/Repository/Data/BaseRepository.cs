using Microsoft.EntityFrameworkCore;
using OpenPath.Utility.Repository.Interface;
using OpenPath.Utility.Repository.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OpenPath.Utility.Repository.Data {

    public class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class {

        protected readonly DbContext _dbContext;
        internal DbSet<TEntity> _dbSet;

        public BaseRepository(DbContext dbContext) {

            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();

        }

        public void Create(TEntity entity) {

            _dbSet.Add(entity);

        }

        public async Task CreateAsync(TEntity entity) {

            await _dbSet.AddAsync(entity);

        }

        public void CreateRange(IEnumerable<TEntity> entities) {

            _dbSet.AddRange(entities);

        }

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities) {

            await _dbContext
                .Set<TEntity>()
                .AddRangeAsync(entities);

        }

        public IQueryable<TEntity> Read() {

            return _dbSet;

        }

        public TEntity ReadById(TKey id) {

            return _dbSet.Find(id);

        }

        public async Task<TEntity> ReadByIdAsync(TKey id) {

            return await _dbSet.FindAsync(id);

        }

        public async Task<bool> UpdateAsync(TEntity entity) {

            var existingEntityId = getPrimaryKey(entity);
            var existingEntity = await ReadByIdAsync(existingEntityId);

            existingEntity = entity;

            return true;


        }

        public void Delete(TEntity entity) {

            _dbSet.Remove(entity);

        }

        public void DeleteRange(IEnumerable<TEntity> entities) {

            _dbContext
                .Set<TEntity>()
                .RemoveRange(entities);

        }

        public void DeleteById(TKey id) {

            var entity = ReadById(id);

            Delete(entity);

        }

        public void DeleteRangeById(IEnumerable<TKey> ids) {

            foreach (var id in ids) {

                DeleteById(id);

            }

        }

        public IQueryable<TEntity> Filter(IQueryable<TEntity> query, IFilter filter) {

            if (filter == null) filter = new FilterPoco() as IFilter;

            return query
                .Skip((filter.Page - 1) * filter.Limit)
                .Take(filter.Limit);

        }

        private TKey getPrimaryKey(TEntity entity) {

            var keyName = _dbContext.Model.FindEntityType(typeof(TEntity)).FindPrimaryKey().Properties
                .Select(x => x.Name).Single();

            return (TKey)entity.GetType().GetProperty(keyName).GetValue(entity, null);

        }

    }

}
