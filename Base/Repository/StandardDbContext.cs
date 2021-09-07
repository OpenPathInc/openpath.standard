using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using Microsoft.Extensions.Configuration;
using OpenPath.Standard.Base.Data.Database;
using OpenPath.Standard.Base.Repository.Interface;
using System;

namespace OpenPath.Standard.Base.Repository {

    /// <summary>
    /// The base database connection context for connecting to the database.
    /// </summary>
    public class StandardDbContext : DbContext, IStandardDbContext {

        // MEMBERS
        // ====================================================================================================

        /// <summary>
        /// Internal connection string for connecting to the database.
        /// </summary>
        private protected string _connectionString;



        // CONSTRUCTORS
        // ====================================================================================================

        /// <summary>
        /// This constructor should only be used when using Entity Framework Code first and is used
        /// when creating, updating or modifying database objects. The constructor will use this
        /// local libraries project.json file to initalize the database string for connections.
        /// </summary>
        public StandardDbContext() {

            try {

                // look for the local project.json file when using dotnet ef * to execute code
                // first commands and parse out the connection string and save it to the object
                _connectionString = new ConfigurationBuilder()
                    .SetBasePath(@"C:\src\openpath.standard\Base\Repository")
                    .AddJsonFile("project.json")
                    .Build()
                    .GetConnectionString("StandardDbContext");

            }
            // if there was an error it was most likely that the file was missing throw an error
            catch (Exception ex) {

                Console.WriteLine("There was an error loading the project.json file with the following stack trace:");
                Console.WriteLine(ex.ToString());

            }

        }

        /// <summary>
        /// This contructor can be used by Dependancy Injection when injecting the DBContext
        /// Options.
        /// </summary>
        /// <param name="options">
        /// The options to be used by a DbContext. You normally override
        /// OnConfiguring(DbContextOptionsBuilder) or use a DbContextOptionsBuilder to create
        /// instances of this class and it is not designed to be directly constructed in your
        /// application code.
        /// </param>
        public StandardDbContext(
            DbContextOptions<StandardDbContext> options
        ) : base(options) {

            // set the private connection string from the options
            _connectionString = options.FindExtension<SqlServerOptionsExtension>().ConnectionString;

        }

        /// <summary>
        /// This contructor can be used by Dependancy Injection when injecting the database
        /// connection string.
        /// </summary>
        /// <param name="connectionString">The connection string for the database.</param>
        public StandardDbContext(
            string connectionString
        ) : base() {

            // set the passed connection string to private
            _connectionString = connectionString;

        }



        // OVERRIDES
        // ====================================================================================================

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context. The default
        /// implementation of this method does nothing, but it can be overridden in a derived
        /// class such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="builder">
        /// Defines the shape of your entities, the relationships between them, and how they map to
        /// the database.
        /// </param>
        protected override void OnModelCreating(ModelBuilder builder) {

            base.OnModelCreating(builder);

        }

        /// <summary>
        /// This method is called for each instance of the context that is created. The base
        /// implementation does nothing.
        /// </summary>
        /// <param name="optionsBuilder">
        /// A builder used to create or modify options for this context. Databases (and other
        /// extensions) typically define extension methods on this object that allow you to
        /// configure the context.
        /// </param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            // define the database to use and the execution stratigy
            optionsBuilder.UseSqlServer(
                _connectionString,
                sqlServerOptionsAction: sqlOptions => {
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 3,
                        maxRetryDelay: TimeSpan.FromMilliseconds(750),
                        errorNumbersToAdd: null
                    ).CommandTimeout(60);
                }
            );

        }



        // PROPERTIES
        // ====================================================================================================

        /// <summary>
        /// Represents a planet in our solar system.
        /// </summary>
        public DbSet<PlanetModel> Planets { get; set; }

    }

}
