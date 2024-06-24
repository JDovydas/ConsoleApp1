using Microsoft.AspNetCore.Mvc;
using SmallApiTaskDb.Models;
using SmallApiTaskDb.Services;
using System.Xml.Linq;

namespace SmallApiTaskDb.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public IActionResult GetAllCars()
        {
            _logger.LogInformation("Getting all cars from the list");
            var cars = _carService.GetAllCars();
            return Ok(cars);
        }

        [HttpGet("GetCars")]
        public IActionResult GetCarsByColor([FromQuery] string color)
        {
            _logger.LogInformation("Getting cars by color: {color}", color);
            var cars = _carService.GetCarsByColor(color);
            return Ok(cars);
        }

        [HttpPost("AddNewCar")]
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



//APIs - intermediaries that allow different software systems to communicate and work together

//  - simplify development by providing a standardized way for applications to interact with each other

//  - enabling developers to focus on building their own applications without worrying about the complexities of underlying systems.



//How Does an API Work?

//  1. Request - client (which could be a web browser, a mobile app, or other servers), sends a HTTP request via Network to the server.Like GET, POST, PUT, DELETE

//  2. Processing - API receives request and processes it. This might involve retrieving data, updating data, deleting data etc.

//  3. Response - API sends back a response with the result (requested data / status indicating the success or failure of operation.

//      The response also includes HTTP status codes like 200 for success, 404 for not found, 500 for server error etc.

//  4. Parse - The client receives and parses the response. If the request was successful, the client will use the data returned in the response.

//      If there was an error, the client will handle the error based on the information in the response.



// APIs methods that determine what actions can be performed and how data can be manipulated

//  1.  GET: retrieve data from the server.e.g. when you visit a website, your browser sends a GET request to the server to fetch the webpage.

//  2.  POST: POST send data to the server to create or update a resource.For instance, when you submit a form on a website, the data you is typically sent to the server using a POST request.

//  3.  PUT: PUT is similar to POST, but it's typically used to update existing resources on the server. You might use a PUT request to update your user profile information on a website.

//  4.  DELETE: remove a resource from the server. For example, when you delete a file from a cloud storage service, your device sends a DELETE request to the server.

//  5.  PATCH: PATCH is used to make partial updates to a resource.Instead of sending the entire resource to the server, you only send the fields that need to be updated. This can be useful when you want to update just one or a few fields of an existing resource.





//JSON (JavaScript Object Notation):

//  JSON is a lightweight data - interchange format that is easy for humans to read and write and easy for machines to parse and generate.

//  based on a subset of the JavaScript programming language, but it's language-independent, making it widely used in web development.

//Example:

//{

//  "name": "John Doe",

//  "age": 30,

//  "city": "New York"

//}



//XML (eXtensible Markup Language):

//  particularly in older systems or enterprise environments

//  markup language similar to HTML but designed to carry data rather than display it.

//  more extensive compared to JSON, which can make it less readable for humans, but it's still widely used, especially in environments where strict data validation and document structure are required.

//  Example:

//< person >

//  < name > John Doe </ name >

//  < age > 30 </ age >

//  < city > New York </ city >

//</ person >





//These formats are used to serialize (convert objects into a format that can be transmitted over a network)

//                    and deserialize (convert the transmitted format back into objects) data between different systems.

//                    The choice between JSON and XML often depends on factors such as the preferences of the developers, compatibility with existing systems, and performance considerations.

//                    JSON is more commonly used in modern web development due to its simplicity and ease of use.
