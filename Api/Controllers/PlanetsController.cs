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

    [ApiController]
    [Route("[controller]")]
    public class PlanetsController : BaseContoller {

        private readonly ILoggerFactory _loggerFactory;
        private readonly ILogger<PlanetsController> _logger;
        private readonly IPlanetService _planetService;

        public PlanetsController(
            ILoggerFactory loggerFactory,
            IPlanetService planetService
        ) {

            _loggerFactory = loggerFactory;
            _logger = loggerFactory.CreateLogger<PlanetsController>();
            _planetService = planetService;

        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] IEnumerable<PlanetModel> planets) {

            await _planetService.AddUpdateAsync(planets);

            var envelope = new EnvelopePoco<PlanetModel>();

            return Ok(planets);

        }

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

        [HttpGet("{idKey}")]
        public async Task<IActionResult> Get(string idKey) {

            var id = long.Parse("0");
            var isNumeric = long.TryParse(idKey, out id);

            var planet = isNumeric ? await _planetService.GetAsync(id) : await _planetService.GetAsync(idKey);
            
            var envelope = new EnvelopePoco<PlanetModel>();

            envelope.Data = planet;

            return Ok(envelope);

        }

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
