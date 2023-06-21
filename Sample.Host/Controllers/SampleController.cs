using Microsoft.AspNetCore.Mvc;

namespace Sample.Host.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult GeName()
        {
            return Ok(new { Name = "farshadbehjatnia" });
        }
    }
}