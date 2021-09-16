using System.Threading.Tasks;

namespace WebApi.Software.Standard.Base.Repository.Interface {

    /// <summary>
    /// The base interface used for all CRUD operations agianst the repository for the the database.
    /// </summary>
    public interface IStandardUnitOfWork {

        /// <summary>
        /// Reference to the DB Context underlying the Unit of Work.
        /// </summary>
        IStandardDbContext DbContext { get; }

        /// <summary>
        /// Represents a planet repository in our solar system.
        /// </summary>
        IPlanet Planets { get; }

        /// <summary>
        /// Commits all database changes to this unit of work.
        /// </summary>
        /// <returns>The amout of rows updated.</returns>
        int Commit();

        /// <summary>
        /// Commits all database changes to this unit of work.
        /// </summary>
        /// <returns>The amout of rows updated.</returns>
        Task<int> CommitAsync();

    }

}
