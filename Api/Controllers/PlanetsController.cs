using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpenPath.Standard.Base.Data.Database;
using OpenPath.Standard.Base.Service.Interface;
using OpenPath.Standard.Base.Data.Poco;

namespace OpenPath.Standard.Api.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class PlanetsController : ControllerBase {

        private readonly ILogger<PlanetsController> _logger;
        private readonly IPlanetService _planetService;

        public PlanetsController(
            ILogger<PlanetsController> logger,
            IPlanetService planetService
        ) {

            _logger = logger;
            _planetService = planetService;

        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PlanetFilterPoco filter) {

            var filteredPlanets = await _planetService.ListAsync(filter);

            //Get the data for the current page  
            var result = new EnvelopePoco<PlanetModel>();
            result.Data = filteredPlanets;
  
            //Get next page URL string  
            var nextFilter = filter.Clone(1) as PlanetFilterPoco;  
            var nextUrl = (await _planetService.ListAsync(nextFilter)).Count() <= 0 ? null : this.Url.Action("Get", null, nextFilter, Request.Scheme);  
  
            //Get previous page URL string  
            var previousFilter = filter.Clone(-1) as PlanetFilterPoco;  
            var previousUrl = previousFilter.Page <= 0 ? null : this.Url.Action("Get", null, previousFilter, Request.Scheme);  
  
            result.NextPage = !String.IsNullOrWhiteSpace(nextUrl) ? new Uri(nextUrl) : null;  
            result.LastPage = !String.IsNullOrWhiteSpace(previousUrl) ? new Uri(previousUrl) : null;  

            return Ok(result);

        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]PlanetModel planet) {

            return Ok(await _planetService.AddAsync(planet));

        }

    }

}
