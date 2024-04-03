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

        public IEnumerable<Car> GetAllCars()
        {
            return _carRepository.GetAllCars().ToList();
        }

        public List<Car> GetCarsByColor(string color)
        {
            return _carRepository.GetAllCars().Where(car => car.Color == color).ToList(); /// to be moved to Repository
        }

        public void AddNewCar(Car car)
        {
            _carRepository.AddNewCar(car);
        }


        public void UpdateCar(int id, Car updatedCar)
        {
            _carRepository.UpdateCar(id, updatedCar);
        }

        public void DeleteCar(int id)
        {
            _carRepository.DeleteCar(id);
        }

    }


}
