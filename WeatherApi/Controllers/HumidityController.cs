using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using WeatherApi.Services;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumidityController : ControllerBase
    {

        [HttpGet]
        [Route("/GetHumidity")]
        [ProducesResponseType(typeof(int), 200)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 400, "Error message")]
        [ProducesDefaultResponseType(typeof(string))]

        public ActionResult<int> Get(int numb)
        {
            if (numb <= 0)
            {
                //return 0;

                return BadRequest("Number is below 0");
                //return NotFound();

            }

            //return CreatedAtAction(nameof(Get), numb);
            return Ok(numb);
            //return StatusCode(524, "I don't know what happened");

        }
    }
}
