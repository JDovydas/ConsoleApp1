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

        public IEnumerable<Car> GetAll()
        {
            return _carData.Cars;
        }

        public void Add(Car car)
        {
            car.Id = _carData.Cars.OrderBy(p => p.Id).Last().Id + 1;
            _carData.Cars.Add(car);
        }

        public void Update(int id, Car updatedCar)
        {
            var existingCar = _carData.Cars.FirstOrDefault(c => c.Id == id);
            if (existingCar != null)
            {
                existingCar.Make = updatedCar.Make;
                existingCar.Year = updatedCar.Year;
                existingCar.Color = updatedCar.Color;
            }
        }

        public void Delete(int id)
        {
            var carToRemove = _carData.Cars.FirstOrDefault(c => c.Id == id);
            if (carToRemove != null)
            {
                _carData.Cars.Remove(carToRemove);
            }
        }


    }
}
