﻿using JWTAuthenticationAndAuthorization.Models;

namespace JWTAuthenticationAndAuthorization.Services
{
    public interface ICarService
    {
        public IEnumerable<Car> GetAllCars();
        IEnumerable<Car> GetCarsByColor(string color);
        void AddNewCar(Car car);
        void UpdateCar(int id, Car updatedCar);
        void DeleteCar(int id);

    }
}
