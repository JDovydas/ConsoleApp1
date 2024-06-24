using SmallApiTaskAzure.Data;
using SmallApiTaskAzure.Models;

namespace SmallApiTaskAzure.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        public void AddNewCar(Car car);
        public void UpdateCar(int id, Car updatedCar);
        public void DeleteCar(int id);

    }

}
