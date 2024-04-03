using SmallApiTask.Models;

namespace SmallApiTask.Services
{
    public interface ICarService
    {
        public IEnumerable<CarDto> GetAll();
        List<CarDto> GetCarsByColor(string color);
        void AddNewCar(CarDto car);
        void UpdateCar(int id, CarDto updatedCar);
        void DeleteCar(int id);

    }
}
