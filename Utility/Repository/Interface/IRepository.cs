using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Software.Utility.Repository.Interface {

    /// <summary>
    /// A generic repositiory pattern for apply basic C.R.U.D. (Create, Read, Update and Delete)
    /// operations on a given entity.
    /// </summary>
    /// <typeparam name="TEntity">The entity type that inhearits this class.</typeparam>
    /// <typeparam name="TKey">The entity primary key type that inhearits this class.</typeparam>
    public interface IRepository<TEntity, TKey> where TEntity : class {

        // CRUD METHODS
        // ====================================================================================================

        // C - create
        // ====================================================================================================

        /// <summary>
        /// Creates a new entity associated to the Unit of Work.
        /// </summary>
        /// <param name="entity">The entity to create in the Unit of Work.</param>
        void Create(TEntity entity);

        /// <summary>
        /// Creates a new entity associated to the Unit of Work.
        /// </summary>
        /// <param name="entity">The entity to create in the Unit of Work.</param>
        Task CreateAsync(TEntity entity);

        /// <summary>
        /// Creates new entities associated to the Unit of Work.
        /// </summary>
        /// <param name="entities">A list of entities to create.</param>
        void CreateRange(IEnumerable<TEntity> entities);

        /// <summary>
        /// Creates new entities associated to the Unit of Work.
        /// </summary>
        /// <param name="entities">A list of entities to create.</param>
        Task CreateRangeAsync(IEnumerable<TEntity> entities);

        // R - read
        // ====================================================================================================

        /// <summary>
        /// Builds a query of all the available entities in the database.
        /// </summary>
        /// <returns>A queryable list of entities.</returns>
        IQueryable<TEntity> Read();        

        /// <summary>
        /// Reads a single entity from the database based on the entity ID.
        /// </summary>
        /// <param name="id">The ID of the entity to read.</param>
        /// <returns>The complete entity, if found, associated to the ID.</returns>
        TEntity ReadById(TKey id);

        /// <summary>
        /// Reads a single entity from the database based on the entity ID.
        /// </summary>
        /// <param name="id">The ID of the entity to read.</param>
        /// <returns>The complete entity, if found, associated to the ID.</returns>
        Task<TEntity> ReadByIdAsync(TKey id);

        // U - update
        // ====================================================================================================

        /// <summary>
        /// Updates changes made to the entity in the database context.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        void Update(TEntity entity);

        /// <summary>
        /// Updates changes made to the entity in the database context.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        Task UpdateAsync(TEntity entity);

        // D - delete
        // ====================================================================================================

        /// <summary>
        /// Deletes an entity..
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Deletes an group of entities.
        /// </summary>
        /// <param name="entities">A list of entities to delete.</param>
        void DeleteRange(IEnumerable<TEntity> entities);

        /// <summary>
        /// Deletes an entity by ID.
        /// </summary>
        /// <param name="id">The ID of the entity to delete.</param>
        void DeleteById(TKey id);

        /// <summary>
        /// Deletes a group of entities by ID's.
        /// </summary>
        /// <param name="ids">A list of entity ID's to delete.</param>
        void DeleteRangeById(IEnumerable<TKey> ids);

        // METHODS
        // ====================================================================================================

        /// <summary>
        /// Filters an existing entity by a page and a limit.
        /// </summary>
        /// <param name="query">The queried entity list.</param>
        /// <param name="filter">The filter to apply to the query.</param>
        /// <returns>A filtered query.</returns>
        IQueryable<TEntity> Filter(IQueryable<TEntity> query, IFilter filter);

    }

}
