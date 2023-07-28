using Microsoft.AspNetCore.Mvc;
using Sample.Application;
using Sample.Core;

namespace Sample.Host.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private SampleService _sampleService => Extentions.GetService<SampleService>();

        public SampleController()
        { }

        [HttpGet]
        public async Task<IActionResult> GeName()
        {
            return await Task.Run(() => { return Ok(new { Name = _sampleService.GeName() }); });
        }
    }
}