using Microsoft.AspNetCore.Mvc;
using SmallApiTaskAzure.Models;
using SmallApiTaskAzure.Services;
using System.Xml.Linq;

namespace SmallApiTaskAzure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetAllCars")]
        public IActionResult GetAll()
        {
            var cars = _carService.GetAllCars();
            return Ok(cars);
        }

        [HttpGet("GetCarsByColor")]
        public IActionResult GetCarsByColor([FromQuery] string color)
        {
            var cars = _carService.GetCarsByColor(color);
            return Ok(cars);
        }

        [HttpGet("New")]
        public string Get()
        {
            return "This is the result";
        }

        [HttpPost("AddNewCar")]
        public IActionResult AddNewCar([FromBody] Car car)
        //public IActionResult AddNewCar(Car car)
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
