using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazorise.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        public EmpController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

    }
}
