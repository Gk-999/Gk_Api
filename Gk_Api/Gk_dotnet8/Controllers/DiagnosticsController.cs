using Microsoft.AspNetCore.Mvc;

namespace Gk_dotnet8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiagnosticsController : ControllerBase
    {
        private readonly ILogger<DiagnosticsController> _logger;

        public DiagnosticsController(ILogger<DiagnosticsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ping")]
        public IActionResult Ping()
        {
            _logger.Log(LogLevel.Information, "Ping Invoked");
            return Content("pong");
        }
    }
}
