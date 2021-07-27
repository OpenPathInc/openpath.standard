using Microsoft.EntityFrameworkCore;
using OpenPath.Utility.Repository.Interface;
using OpenPath.Utility.Repository.Poco;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OpenPath.Utility.Repository.Data {

    public class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class {

        protected readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext) {

            _dbContext = dbContext;

        }

        public void Add(TEntity entity) {

            _dbContext
                .Set<TEntity>()
                .Add(entity);

        }

        public async Task AddAsync(TEntity entity) {

            await _dbContext
                .Set<TEntity>()
                .AddAsync(entity);

        }

        public TEntity GetById(TKey id) {

            var entityType = _dbContext.Model.FindEntityType(typeof(TEntity));
            var key = entityType.FindPrimaryKey();
            var entries = _dbContext.ChangeTracker.Entries<TEntity>();

            var i = 0;

            foreach (var property in key.Properties) {

                entries = entries.Where(e => e.Property(property.Name).CurrentValue == id as object);
                i++;

            }

            var entry = entries.First();

            if (entry != null) return entry.Entity;

            var parameter = Expression.Parameter(typeof(TEntity), "x");
            var query = _dbContext
                .Set<TEntity>()
                .Where(
                    (Expression<Func<TEntity, bool>>)
                    Expression.Lambda(
                        Expression.Equal(
                            Expression.Property(parameter, key.Properties[0].Name),
                            Expression.Constant(id)
                        ),
                        parameter
                    )
                );

            return query.First();

        }

        public async Task<TEntity> GetByIdAsync(TKey id) {

            var entityType = _dbContext.Model.FindEntityType(typeof(TEntity));
            var key = entityType.FindPrimaryKey();
            var entries = _dbContext.ChangeTracker.Entries<TEntity>();

            var i = 0;

            foreach (var property in key.Properties) {

                entries = entries.Where(e => e.Property(property.Name).CurrentValue == id as object);
                i++;

            }

            var entry = entries.First();

            if (entry != null) return entry.Entity;

            var parameter = Expression.Parameter(typeof(TEntity), "x");
            var query = _dbContext
                .Set<TEntity>()
                .Where(
                    (Expression<Func<TEntity, bool>>)
                    Expression.Lambda(
                        Expression.Equal(
                            Expression.Property(parameter, key.Properties[0].Name),
                            Expression.Constant(id)
                        ),
                        parameter
                    )
                );

            return await query.FirstAsync();

        }

        public IQueryable<TEntity> List() {

            return _dbContext.Set<TEntity>();                                    

        }

        public IQueryable<TEntity> Filter(IQueryable<TEntity> query, IFilter filter) {

            if (filter == null) filter = new FilterPoco() as IFilter;

            return query                
                .Skip((filter.Page - 1) * filter.Limit)
                .Take(filter.Limit);                                    

        }

    }

}
