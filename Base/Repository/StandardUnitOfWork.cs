using WebApi.Software.Standard.Base.Repository.Data;
using WebApi.Software.Standard.Base.Repository.Interface;
using System;
using System.Threading.Tasks;

namespace WebApi.Software.Standard.Base.Repository {

    /// <summary>
    /// The base class used for all CRUD operations agianst the repository for the the database.
    /// </summary>
    public class StandardUnitOfWork : IStandardUnitOfWork, IDisposable {

        // MEMBERS
        // ====================================================================================================

        /// <summary>
        /// The private context for the Unit of Work.
        /// </summary>
        private readonly StandardDbContext _standardDbContext;



        // CONSTRUCTORS
        // ====================================================================================================

        /// <summary>
        /// This is constructor should be used by the dependancy inject of the calling project to
        /// initalize the Unit of Work for the database.
        /// </summary>
        /// <param name="standardDbContext">
        /// A DbContext instance represents a combination of the Unit Of Work and Repository
        /// patterns such that it can be used to query from a database and group together changes
        /// that will then be written back to the store as a unit. DbContext is conceptually
        /// similar to ObjectContext.
        /// </param>
        public StandardUnitOfWork(StandardDbContext standardDbContext) {

            _standardDbContext = standardDbContext;

            Planets = new PlanetRepository(_standardDbContext);

        }



        // PROPERTIES
        // ====================================================================================================

        /// <summary>
        /// Reference to the DB Context underlying the Unit of Work.
        /// </summary>
        public IStandardDbContext DbContext => _standardDbContext;


        /// <summary>
        /// Represents a planet repository in our solar system.
        /// </summary>
        public IPlanet Planets { get; private set; }



        // METHODS
        // ====================================================================================================

        /// <summary>
        /// Commits all database changes to this unit of work.
        /// </summary>
        /// <returns>The amout of rows updated.</returns>
        public int Commit() {

            return _standardDbContext.SaveChanges();

        }

        /// <summary>
        /// Commits all database changes to this unit of work.
        /// </summary>
        /// <returns>The amout of rows updated.</returns>
        public async Task<int> CommitAsync() {

            return await _standardDbContext.SaveChangesAsync();

        }

        /// <summary>
        /// Required for memory cleanup and release and reset unmanaged resources, such as file
        /// handles and database connections.
        /// </summary>
        public void Dispose() {

            _standardDbContext.Dispose();

        }

        /// <summary>
        /// Required for memory cleanup and release and reset unmanaged resources, such as file
        /// handles and database connections.
        /// </summary>
        public async Task DisposeAsync() {

            await _standardDbContext.DisposeAsync();

        }

    }

}
