using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpenPath.Standard.Base.Data.Database;
using OpenPath.Standard.Base.Service.Interface;
using OpenPath.Standard.Base.Data.Poco;
using System.Collections.Generic;

namespace OpenPath.Standard.Api.Controllers {

    /// <summary>
    /// Endpoints for managing Planet data.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class PlanetsController : BaseContoller {

        // MEMBERS
        // ====================================================================================================

        /// <summary>
        /// Represents a type used to configure the logging system and create instances of
        /// Microsoft.Extensions.Logging.ILogger from the registered
        /// Microsoft.Extensions.Logging.ILoggerProviders.
        /// </summary>
        private readonly ILoggerFactory _loggerFactory;

        /// <summary>
        /// A generic interface for logging where the category name is derived from the specified
        /// TCategoryName type name. Generally used to enable activation of a named
        /// Microsoft.Extensions.Logging.ILogger from dependency injection.
        /// </summary>
        private readonly ILogger<PlanetsController> _logger;

        /// <summary>
        /// Service to Manage Planets.
        /// </summary>
        private readonly IPlanetService _planetService;



        // CONSTRUCTORS
        // ====================================================================================================

        /// <summary>
        /// The Planets endpoint constructor.
        /// </summary>
        /// <param name="loggerFactory">The Microsoft Logger Factory.</param>
        /// <param name="planetService">Service to Manage Planets.</param>
        public PlanetsController(
            ILoggerFactory loggerFactory,
            IPlanetService planetService
        ) {

            // associate the injected services
            _loggerFactory = loggerFactory;
            _logger = loggerFactory.CreateLogger<PlanetsController>();
            _planetService = planetService;

        }



        // HTTP VERBS
        // ====================================================================================================

        /// <summary>
        /// Accepts an array of new or updated planets and either creates or updates them. This
        /// endpoint can handle a mixture of both.
        /// </summary>
        /// <param name="planets">An array of Planets.</param>
        /// <returns>Returns an evelope with the updated and/or created planets in the data.</returns>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] IEnumerable<PlanetModel> planets) {

            // add and/or update planets
            await _planetService.AddUpdateAsync(planets);

            // create the envelope
            var envelope = new EnvelopePoco<IEnumerable<PlanetModel>>();

            // update the envelope data
            envelope.Data = planets;

            // return the envelope
            return Ok(envelope);

        }

        /// <summary>
        /// Gets a filtered array of Planets.
        /// </summary>
        /// <param name="filter">Filter Parameters</param>
        /// <returns>Returns an evelope with filtered planets in the data.</returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PlanetFilterPoco filter) {

            var filteredPlanets = await _planetService.ListAsync(filter);

            var envelope = new EnvelopePoco<IEnumerable<PlanetModel>>();
            var nextFilter = filter.Clone(1) as PlanetFilterPoco;
            var previousFilter = filter.Clone(-1) as PlanetFilterPoco;
            var nextUrl = (await _planetService.ListAsync(nextFilter)).Count() <= 0 ? null : this.Url.Action("Get", null, nextFilter, Request.Scheme);
            var previousUrl = previousFilter.Page <= 0 ? null : this.Url.Action("Get", null, previousFilter, Request.Scheme);

            envelope.Data = filteredPlanets;
            envelope.NextPage = !String.IsNullOrWhiteSpace(nextUrl) ? new Uri(nextUrl) : null;
            envelope.LastPage = !String.IsNullOrWhiteSpace(previousUrl) ? new Uri(previousUrl) : null;

            return Ok(envelope);

        }

        /// <summary>
        /// Returns a single Planet by Planet ID or Planet Key.
        /// </summary>
        /// <param name="idKey">The Planet ID or Key.</param>
        /// <returns>A an Envelope with Planet data.</returns>
        [HttpGet("{idKey}")]
        public async Task<IActionResult> Get(string idKey) {

            var id = long.Parse("0");
            var isNumeric = long.TryParse(idKey, out id);

            var planet = isNumeric ? await _planetService.GetAsync(id) : await _planetService.GetAsync(idKey);
            
            var envelope = new EnvelopePoco<PlanetModel>();

            envelope.Data = planet;

            return Ok(envelope);

        }

        /// <summary>
        /// Deletes a single Planet by Planet ID or Planet Key.
        /// </summary>
        /// <param name="idKey">The Planet ID or Key.</param>
        /// <returns>If the delete was successfull.</returns>
        [HttpDelete("{idKey}")]
        public async Task<IActionResult> DeleteAsync(string idKey) {

            var id = long.Parse("0");
            var isNumeric = long.TryParse(idKey, out id);

            if (isNumeric) {
                await _planetService.RemoveAsync(id);
            }
            else {
                await _planetService.RemoveAsync(idKey);
            }

            return Ok();

        }

    }

}
