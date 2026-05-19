using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace astronnCRM.Api.Areas.PublicArea.Controllers
{
    [Area("PublicArea")]
    [DisplayName("Public controller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    public class PublicController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Ohayou from Public Area!");
        }
    }
}
