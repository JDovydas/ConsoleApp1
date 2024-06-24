using JWTAuthenticationAndAuthorization.Models;
using JWTAuthenticationAndAuthorization.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthenticationAndAuthorization.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarService _carService;

        public CarController(ILogger<CarController> logger, ICarService carService)
        {
            _logger = logger;
            _carService = carService;
        }

        [HttpGet("GetAllCars")]
        [Authorize(Roles = "User, Admin")]
        public IActionResult GetAllCars()
        {
            _logger.LogInformation("Getting all cars from the list");
            var cars = _carService.GetAllCars();
            return Ok(cars);
        }

        [HttpGet("GetCarsByColor")]
        [Authorize(Roles = "User, Admin")]
        public IActionResult GetCarsByColor([FromQuery] string color)
        {
            _logger.LogInformation("Getting cars by color: {color}", color);
            var cars = _carService.GetCarsByColor(color);
            return Ok(cars);
        }

        [HttpPost("AddNewCar")]
        [Authorize(Roles = "Admin")]
        public IActionResult AddNewCar([FromBody] Car car)
        //public IActionResult AddNewCar(Car car)
        {

            try
            {
                var newCar = new Car()
                {
                    Id = car.Id,
                    Make = car.Make,
                    Year = car.Year,
                    Color = car.Color,

                };
                _logger.LogInformation(@"Added a new car id: {Id} Make: {Make}, Year: {Year}, Color: {Color}", car.Id, car.Make, car.Make, car.Color);
                _carService.AddNewCar(newCar);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding a new car: {@car}", car);
                return StatusCode(500, "Internal server error");
            }
        }



        [HttpPut("UpdateCar")]
        [Authorize(Roles = "Admin")]
        public IActionResult UpdateCar(int id, [FromBody] Car updatedCar)
        {
            _carService.UpdateCar(id, updatedCar);
            return Ok();
        }

        [HttpDelete("DeleteCar")]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteCar(int id)
        {
            _carService.DeleteCar(id);
            return Ok();
        }

    }
}
