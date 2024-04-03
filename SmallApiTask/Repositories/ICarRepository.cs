using SmallApiTask.Data;
using SmallApiTask.Models;

namespace SmallApiTask.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<CarDto> GetAll();
        public void Add(CarDto car);
        public void Update(int id, CarDto updatedCar);
        public void Delete(int id);

    }

}
