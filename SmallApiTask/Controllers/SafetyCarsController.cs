using Microsoft.AspNetCore.Mvc;
using SmallApiTask.Models;
using SmallApiTask.Services;
using System.Xml.Linq;

namespace SmallApiTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SafetyCarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public SafetyCarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetAllCars")]
        public IActionResult GetAll()
        {
            var cars = _carService.GetAll();
            return Ok(cars);
        }

        [HttpGet("GetCarsByColor")]
        public IActionResult GetCarsByColor([FromQuery] string color)
        {
            var cars = _carService.GetCarsByColor(color);
            return Ok(cars);
        }

        [HttpPost("AddNewCar")]
        public IActionResult AddNewCar([FromBody] Car car)
        {
            _carService.AddNewCar(car);
            return Ok();
        }

        [HttpPut("UpdateCar")]
        public IActionResult UpdateCar(int id, [FromBody] Car updatedCar)
        {
            _carService.UpdateCar(id, updatedCar);
            return Ok();
        }

        [HttpDelete("DeleteCar")]
        public IActionResult DeleteCar(int id)
        {
            _carService.DeleteCar(id);
            return Ok();
        }

    }
}
