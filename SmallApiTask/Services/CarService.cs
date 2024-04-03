using SmallApiTask.Models;
using SmallApiTask.Data;
using SmallApiTask.Repositories;

namespace SmallApiTask.Services
{
    public class CarService : ICarService
    {

        private readonly ICarRepository _carsRepository;

        public CarService(ICarRepository safetyCarsRepository)
        {
            _carsRepository = safetyCarsRepository;
        }


        public IEnumerable<CarDto> GetAll()
        {
            return _carsRepository.GetAll().ToList();
        }

        public List<CarDto> GetCarsByColor(string color)
        {
            return _carsRepository.GetAll().Where(c => c.Color == color).ToList();
        }

        public void AddNewCar(CarDto car)
        {
            _carsRepository.Add(car);
        }




        public void UpdateCar(int id, CarDto updatedCar)
        {
            _safetyCarsRepository.Update(id, updatedCar);

        }

        public void DeleteCar(int id)
        {
            _safetyCarsRepository.Delete(id);
        }

    }


}
