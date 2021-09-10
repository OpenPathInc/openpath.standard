using Microsoft.EntityFrameworkCore;
using OpenPath.Utility.Repository.Interface;
using OpenPath.Utility.Repository.Poco;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenPath.Utility.Repository.Data {

    /// <summary>
    /// A generic repositiory pattern for apply basic C.R.U.D. (Create, Read, Update and Delete)
    /// operations on a given entity.
    /// </summary>
    /// <typeparam name="TEntity">The entity type that inhearits this class.</typeparam>
    /// <typeparam name="TKey">The entity primary key type that inhearits this class.</typeparam>
    public class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class {

        // MEMBERS
        // ====================================================================================================

        /// <summary>
        /// The base DB Context for the Resposity.
        /// </summary>
        protected readonly DbContext _dbContext;

        /// <summary>
        /// The DB Set to execute transactions against.
        /// </summary>
        internal DbSet<TEntity> _dbSet;

        /// <summary>
        /// Constructor for building the base repository.
        /// </summary>
        /// <param name="dbContext">The DB Context for the Reposity.</param>
        public BaseRepository(DbContext dbContext) {

            // set the database context
            _dbContext = dbContext;

            // create a reference to the database data type passed by tentity
            _dbSet = _dbContext.Set<TEntity>();

        }



        // CRUD METHODS
        // ====================================================================================================

        // C - create
        // ====================================================================================================

        /// <summary>
        /// Creates a new entity associated to the Unit of Work.
        /// </summary>
        /// <param name="entity">The entity to create in the Unit of Work.</param>
        public void Create(TEntity entity) {

            // add the entity to the database context
            _dbSet.Add(entity);

        }

        /// <summary>
        /// Creates a new entity associated to the Unit of Work.
        /// </summary>
        /// <param name="entity">The entity to create in the Unit of Work.</param>
        public async Task CreateAsync(TEntity entity) {

            // add the entity to the database context
            await _dbSet.AddAsync(entity);

        }

        /// <summary>
        /// Creates new entities associated to the Unit of Work.
        /// </summary>
        /// <param name="entities">A list of entities to create.</param>
        public void CreateRange(IEnumerable<TEntity> entities) {

            // add the arrary of entities to the database context
            _dbSet.AddRange(entities);

        }

        /// <summary>
        /// Creates new entities associated to the Unit of Work.
        /// </summary>
        /// <param name="entities">A list of entities to create.</param>
        public async Task CreateRangeAsync(IEnumerable<TEntity> entities) {

            // add the arrary of entities to the database context
            await _dbSet.AddRangeAsync(entities);

        }

        // R - read
        // ====================================================================================================

        /// <summary>
        /// Builds a query of all the available entities in the database.
        /// </summary>
        /// <returns>A queryable list of entities.</returns>
        public IQueryable<TEntity> Read() {

            // create an entity query
            return _dbSet;

        }

        /// <summary>
        /// Reads a single entity from the database based on the entity ID.
        /// </summary>
        /// <param name="id">The ID of the entity to read.</param>
        /// <returns>The complete entity, if found, associated to the ID.</returns>
        public TEntity ReadById(TKey id) {

            // find the entity by id
            return _dbSet.Find(id);

        }

        /// <summary>
        /// Reads a single entity from the database based on the entity ID.
        /// </summary>
        /// <param name="id">The ID of the entity to read.</param>
        /// <returns>The complete entity, if found, associated to the ID.</returns>
        public async Task<TEntity> ReadByIdAsync(TKey id) {

            // find the entity by id
            return await _dbSet.FindAsync(id);

        }

        // U - update
        // ====================================================================================================

        /// <summary>
        /// Updates changes made to the entity in the database context.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        public void Update(TEntity entity) {

            // get the entities id to look up in the database
            var existingEntityId = getPrimaryKey(entity);

            // load the existing database entity
            var existingEntity = ReadById(existingEntityId);

            // update the database entity with the new entity data
            existingEntity = entity;

        }

        /// <summary>
        /// Updates changes made to the entity in the database context.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        public async Task UpdateAsync(TEntity entity) {

            // get the entities id to look up in the database
            var existingEntityId = getPrimaryKey(entity);

            // load the existing database entity
            var existingEntity = await ReadByIdAsync(existingEntityId);

            // update the database entity with the new entity data
            existingEntity = entity;

        }

        // D - delete
        // ====================================================================================================

        /// <summary>
        /// Deletes an entity..
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        public void Delete(TEntity entity) {

            // remove the entity
            _dbSet.Remove(entity);

        }

        /// <summary>
        /// Deletes an group of entities.
        /// </summary>
        /// <param name="entities">A list of entities to delete.</param>
        public void DeleteRange(IEnumerable<TEntity> entities) {

            // remove the list of entities
            _dbSet.RemoveRange(entities);

        }

        /// <summary>
        /// Deletes an entity by ID.
        /// </summary>
        /// <param name="id">The ID of the entity to delete.</param>
        public void DeleteById(TKey id) {

            // find the entity by id
            var entity = ReadById(id);

            // delete that entity
            Delete(entity);

        }

        /// <summary>
        /// Deletes a group of entities by ID's.
        /// </summary>
        /// <param name="ids">A list of entity ID's to delete.</param>
        public void DeleteRangeById(IEnumerable<TKey> ids) {

            // loop through each id
            foreach (var id in ids) {

                // delete the entity by id
                DeleteById(id);

            }

        }



        // METHODS
        // ====================================================================================================

        /// <summary>
        /// Filters an existing entity by a page and a limit.
        /// </summary>
        /// <param name="query">The queried entity list.</param>
        /// <param name="filter">The filter to apply to the query.</param>
        /// <returns>A filtered query.</returns>
        public IQueryable<TEntity> Filter(IQueryable<TEntity> query, IFilter filter) {

            if (filter == null) filter = new FilterPoco() as IFilter;

            return query
                .Skip((filter.Page - 1) * filter.Limit)
                .Take(filter.Limit);

        }



        // HELPERS
        // ====================================================================================================

        /// <summary>
        /// Finds the primary key value within an entity.
        /// </summary>
        /// <param name="entity">The entity to find the primary key value of.</param>
        /// <returns>The primary key value.</returns>
        private TKey getPrimaryKey(TEntity entity) {

            // find the name of the primary key in the entity
            var keyName = _dbContext.Model
                .FindEntityType(typeof(TEntity))
                .FindPrimaryKey()
                .Properties
                .Select(_ => _.Name)
                .Single();

            // get the primary key by the name
            var keyValue = (TKey)entity
                .GetType()
                .GetProperty(keyName)
                .GetValue(entity, null);

            // return the primary key value
            return keyValue;

        }

    }

}
