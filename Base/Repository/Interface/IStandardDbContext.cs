using Microsoft.EntityFrameworkCore;
using OpenPath.Standard.Base.Data.Database;

namespace OpenPath.Standard.Base.Repository.Interface {

    /// <summary>
    /// The base database connection context Interface for connecting to the database.
    /// </summary>
    public interface IStandardDbContext {

        /// <summary>
        /// Represents a planet in our solar system.
        /// </summary>
        DbSet<PlanetModel> Planets { get; }

    }

}
