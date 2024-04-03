using SmallApiTask.Models;
using SmallApiTask.Data;
using SmallApiTask.Repositories;

namespace SmallApiTask.Services
{
    public class CarService : ICarService
    {

        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IEnumerable<Car> GetAll()
        {
            return _carRepository.GetAll().ToList();
        }

        public List<Car> GetCarsByColor(string color)
        {
            return _carRepository.GetAll().Where(c => c.Color == color).ToList();
        }

        public void AddNewCar(Car car)
        {
            _carRepository.Add(car);
        }


        public void UpdateCar(int id, Car updatedCar)
        {
            _carRepository.Update(id, updatedCar);
        }

        public void DeleteCar(int id)
        {
            _carRepository.Delete(id);
        }

    }


}
