using SmallApiTaskAzure.Models;

namespace SmallApiTaskAzure.Services
{
    public interface ICarService
    {
        public IEnumerable<Car> GetAllCars();
        List<Car> GetCarsByColor(string color);
        void AddNewCar(Car car);
        void UpdateCar(int id, Car updatedCar);
        void DeleteCar(int id);

    }
}
