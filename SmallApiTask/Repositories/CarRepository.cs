using SmallApiTask.Models;

using SmallApiTask.Data;

namespace SmallApiTask.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ICarData _carData;

        public CarRepository(ICarData carData)
        {
            _carData = carData;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _carData.Cars;
        }

        public void AddNewCar(Car car)
        {
            if (_carData.Cars.Any(p => p.Id == car.Id))
            {
                throw new Exception("Car with the same ID already exists"); //SameIdException
            }
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            if (string.IsNullOrWhiteSpace(car.Make))
            {
                throw new ArgumentException("Car make cannot be empty.", nameof(car.Make));

            }

            car.Id = _carData.Cars.OrderBy(c => c.Id).Last().Id + 1;
            _carData.Cars.Add(car);
        }

        public void UpdateCar(int id, Car updatedCar)
        {
            var existingCar = _carData.Cars.FirstOrDefault(c => c.Id == id);
            if (existingCar != null)
            {
                existingCar.Make = updatedCar.Make;
                existingCar.Year = updatedCar.Year;
                existingCar.Color = updatedCar.Color;
            }
        }

        public void DeleteCar(int id)
        {
            var carToRemove = _carData.Cars.FirstOrDefault(c => c.Id == id);
            if (carToRemove != null)
            {
                _carData.Cars.Remove(carToRemove);
            }
        }


    }
}
