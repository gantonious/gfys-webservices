using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gfys.webservices.Features;
using Microsoft.AspNetCore.Mvc;

namespace gfys.webservices.Controllers
{
    [Route("api/v1/features")]
    public class FeaturesController : Controller
    {
        private readonly IFeatureService _featureService;

        public FeaturesController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [HttpGet]
        public IEnumerable<Feature> GetFeatues()
        {
            return _featureService.GetAllFeatures();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Feature feature)
        {
            _featureService.CreateFeature(feature);
            return Created("", feature);
        }

        [HttpPut("{name}")]
        public IActionResult Put(string name, [FromBody] Feature feature)
        {
            if (_featureService.GetFeature(name) == null)
            {
                return BadRequest();
            }

            feature.Name = name;
            _featureService.UpdateFeature(feature);
            return Ok();
        }

        [HttpDelete("{name}")]
        public IActionResult Delete(string name)
        {
            _featureService.DeleteFeature(name);
            return NoContent();
        }
    }
}
