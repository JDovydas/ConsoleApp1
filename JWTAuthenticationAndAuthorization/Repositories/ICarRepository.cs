
using JWTAuthenticationAndAuthorization.Models;

namespace JWTAuthenticationAndAuthorization.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        public void AddNewCar(Car car);
        public void UpdateCar(int id, Car updatedCar);
        public void DeleteCar(int id);

        public IEnumerable<Car> GetCarsByColor(string color);

    }

}
