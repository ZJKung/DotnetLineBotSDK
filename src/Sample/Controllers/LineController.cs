using System.Threading.Tasks;
using DotnetcoreLineBot.Filters;
using DotnetcoreLineBot.Models.Line;
using Microsoft.AspNetCore.Mvc;
using Sample.Services;

namespace Sample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LineController : ControllerBase
    {
        private readonly LineService _lineService;

        public LineController(LineService lineService)
        {
            _lineService = lineService;
        }

        [LineVerifySignature]
        [HttpPost]
        public async Task<IActionResult> Post(WebHookEvent request)
        {
            await _lineService.RunAsync(request.Events);

            return Ok();
        }
    }
}