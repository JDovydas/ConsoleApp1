using SmallApiTask.Data;
using SmallApiTask.Models;

namespace SmallApiTask.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAll();
        public void Add(Car car);
        public void Update(int id, Car updatedCar);
        public void Delete(int id);

    }

}
