using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using Microsoft.Extensions.Configuration;
using OpenPath.Standard.Base.Data.Database;
using OpenPath.Standard.Base.Repository.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace OpenPath.Standard.Base.Repository {

    public class StandardDbContext : DbContext, IStandardDbContext {

        private protected string _connectionString;

        public StandardDbContext() {

            try {

                _connectionString = new ConfigurationBuilder()
                    .SetBasePath(@"C:\src\openpath.standard\Base\Repository")
                    .AddJsonFile("project.json")
                    .Build()
                    .GetConnectionString("StandardDbContext");

            }
            catch(Exception ex) {

                Console.WriteLine("There was an error loading the project.json file with the following stack trace:");
                Console.WriteLine(ex.ToString());

            }

        }

        public StandardDbContext(
            DbContextOptions<StandardDbContext> options
        ) : base(options) {

            _connectionString = options.FindExtension<SqlServerOptionsExtension>().ConnectionString;
        
        }

        public StandardDbContext(
            string connectionString
        ) : base() {

            _connectionString = connectionString;

        }

        protected override void OnModelCreating(ModelBuilder builder) {

            base.OnModelCreating(builder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            // define the database to use and the execution stratigy
            optionsBuilder.UseSqlServer(
                _connectionString,
                sqlServerOptionsAction:sqlOptions => {
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 3,
                        maxRetryDelay: TimeSpan.FromMilliseconds(750),
                        errorNumbersToAdd: null
                    ).CommandTimeout(60);
                }
            );
      
        }

        public DbSet<PlanetModel> Planets { get; set; }

    }

}
