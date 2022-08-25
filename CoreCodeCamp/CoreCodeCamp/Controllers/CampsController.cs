using Microsoft.AspNetCore.Mvc;

namespace CoreCodeCamp.Controllers
{
    [Route("api/[controller]")]
    public class CampsController : Controller
    {
        [HttpGet]
        public IActionResult GetCamps()
        {
            if (false) return BadRequest("bad request :(");

            return Ok(new { Moniker = "ATL2018", Name = "Atlanta Code" });
        }
    }
}
