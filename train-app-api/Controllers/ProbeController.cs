using Microsoft.AspNetCore.Mvc;

namespace TrainSmart.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProbeController : ControllerBase
    {
        private readonly ILogger<ProbeController> _logger;

        public ProbeController(ILogger<ProbeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Probe")]
        public string Get()
        {
            return "All good here!";
        }
    }
}
