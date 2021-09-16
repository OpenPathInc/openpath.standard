using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Software.Standard.Base.Data.Database;
using WebApi.Software.Standard.Base.Service.Interface;
using WebApi.Software.Standard.Base.Data.Poco;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using WebApi.Software.Utility.Repository.Poco;

namespace WebApi.Software.Standard.Api.V1.Controllers {

    /// <summary>
    /// Endpoints for managing Planet data.
    /// </summary>
    [ApiController]
    [Route("v1/[controller]")]
    public class PlanetsController : BaseContoller {

        // MEMBERS
        // ====================================================================================================
        private readonly IPlanetService _planetService;

        // CONSTRUCTORS
        // ====================================================================================================

        /// <summary>
        /// The Planets endpoint constructor.
        /// </summary>
        /// <param name="loggerFactory">The Microsoft Logger Factory.</param>
        /// <param name="planetService">Service to Manage Planets.</param>
        public PlanetsController (
            ILoggerFactory loggerFactory,
            IPlanetService planetService
        ) : base(loggerFactory) {

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
        /// <response code="200">Returned if all planets were successfully updated.</response>
        /// <response code="201">Returned if all planets were successfully created.</response>
        /// <response code="207">Returned if all planets were successfully updated and created.</response>
        /// <response code="404">Returned if none of the planet references were found.</response>
        /// <response code="406">Returned if there was an issue creating or updating 1 or more planets.</response>
        /// <response code="500">Returned if there is an error within the API.</response>
        [HttpPost]
        [ProducesResponseType(typeof(EnvelopePoco<IEnumerable<PlanetModel>>), 200)]
        [ProducesResponseType(typeof(EnvelopePoco<IEnumerable<PlanetModel>>), 201)]
        [ProducesResponseType(typeof(EnvelopePoco<IEnumerable<PlanetModel>>), 207)]
        [ProducesResponseType(typeof(EnvelopePoco<IEnumerable<PlanetModel>>), 400)]
        [ProducesResponseType(typeof(EnvelopePoco<IEnumerable<PlanetModel>>), 404)]
        [ProducesResponseType(typeof(EnvelopePoco<IEnumerable<PlanetModel>>), 500)]
        public async Task<IActionResult> PostAsync([FromBody] IEnumerable<PlanetModel> planets) {

            try {

                // add and/or update planets
                var response = await _planetService.AddUpdateAsync(planets);

                // return the envelope
                return await Envelope(planets, response);

            }
            catch(Exception ex) {

                return await Envelope(planets, null, new List<string> { ex.Message });

            }
            

        }

        /// <summary>
        /// Gets a filtered array of Planets.
        /// </summary>
        /// <param name="filter">Filter Parameters</param>
        /// <returns>Returns an evelope with filtered planets in the data.</returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PlanetFilterPoco filter) {

            var filteredPlanets = await _planetService.ListAsync(filter);

            // return the envelope
            return await Envelope<IEnumerable<PlanetModel>, PlanetFilterPoco>(filteredPlanets, filter, null);

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
