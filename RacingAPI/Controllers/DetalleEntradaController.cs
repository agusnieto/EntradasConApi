using Microsoft.AspNetCore.Mvc;

namespace RacingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleEntradaController : ControllerBase
    {
        // GET api/<DetalleEntradaController>/Sector/5
        [HttpGet("Sector/{id}")]
        public IActionResult Get(int id)
        {
            //validar
            return Ok();
        }

        // POST api/<DetalleEntradaController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            //validar
            return Ok();
        }
    }
}
