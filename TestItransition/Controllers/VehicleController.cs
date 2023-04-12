using CollectionsProject;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Text.Json;

namespace TestItransition.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;

        public VehicleController(ILogger<VehicleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("getListTransport")]
        [SwaggerResponse(200, Type = typeof(List<Vehicle>))]
        public async Task<IActionResult> GetListTransport()
        {
            var result = new VehicleData();
            _logger.LogInformation(JsonSerializer.Serialize(result.TransportObjects()));
            return Ok(result.TransportObjects());
        }
    }
}