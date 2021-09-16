using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace WebApi.Software.Standard.Api {

    /// <summary>
    /// This is the main API program staring point that fires up the hosting services and Start Up
    /// class.
    /// </summary>
    public class Program {

        // STATIC METHODS
        // ====================================================================================================

        /// <summary>
        /// This is the Main entry method to fire off the application.
        /// </summary>
        /// <param name="args">A string of optional parameters.</param>
        public static void Main(string[] args) {

            CreateHostBuilder(args)
                .Build()
                .Run();

        }

        /// <summary>
        /// Create the web host and fires off the Start Up class.
        /// </summary>
        /// <param name="args">Takes the arguments from the Main method.</param>
        /// <returns>A running web hosting environment.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(
                    webBuilder => {
                        webBuilder.UseStartup<Startup>();
                    }
                );

    }

}
