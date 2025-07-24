using Microsoft.AspNetCore.Mvc;
using Porsche.DTOs;
using Porsche.Services;

namespace Porsche.Controllers
{
    [ApiController]
    [Route("api/portafolio")]
    public class PortafolioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var portafolio = new PortafolioServices();
            return Ok( portafolio.GetPortafolio() );
        }

    }
}

