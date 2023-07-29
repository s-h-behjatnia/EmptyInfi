using Microsoft.AspNetCore.Mvc;
using Sample.Application;
using Sample.Core;
using Sample.Domain;
using Sample.EntityFramework.Queries;
using Sample.Model;

namespace Sample.Host.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private SampleService _sampleService => Extentions.GetService<SampleService>();
        private SampleQueryRepository<SomeModel, int> _queryRepository => Extentions.GetService<SampleQueryRepository<SomeModel, int>>();

        public SampleController()
        { }

        [HttpGet]
        public async Task<IActionResult> GeName()
        {
            var x = _queryRepository.ExecuteQuery("SELECT TOP(1) * FROM dbo.flights");
            return await Task.Run(() => { return Ok(new { Name = _sampleService.GeName() }); });
        }
    }
}