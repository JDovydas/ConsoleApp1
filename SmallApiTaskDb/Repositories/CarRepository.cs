using SmallApiTaskDb.Models;
namespace SmallApiTaskDb.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarContext _context;

        public CarRepository(CarContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _context.Cars;
        }

        public void AddNewCar(Car car)
        {
            if (_context.Cars.Any(p => p.Id == car.Id))
            {
                throw new Exception("Car with the same ID already exists"); //SameIdException in database since "Not null" is preset
            }
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            if (string.IsNullOrWhiteSpace(car.Make))
            {
                throw new ArgumentException("Car make cannot be empty.", nameof(car.Make));

            }
            _context.Cars.Add(car);
            _context.SaveChanges();
            //_logger.LogInformation("New information addedd successfully");
        }

        public void UpdateCar(int id, Car updatedCar)
        {
            var existingCar = _context.Cars.FirstOrDefault(c => c.Id == id);
            if (existingCar != null)
            {
                existingCar.Make = updatedCar.Make;
                existingCar.Year = updatedCar.Year;
                existingCar.Color = updatedCar.Color;
                _context.SaveChanges();
            }
        }

        public void DeleteCar(int id)
        {
            var carToRemove = _context.Cars.FirstOrDefault(c => c.Id == id);
            if (carToRemove != null)
            {
                _context.Cars.Remove(carToRemove);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Car> GetCarsByColor(string color)
        {
            return _context.Cars.Where(car => car.Color == color).ToList();
        }


    }
}
