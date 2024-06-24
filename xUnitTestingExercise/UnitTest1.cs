using AutoFixture.Xunit2;
using AutoMapper;
using Castle.Core.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using SmallApiTaskDb.Controllers;
using SmallApiTaskDb.Models;
using SmallApiTaskDb.Repositories;
using SmallApiTaskDb.Services;

namespace xUnitTestingExercise
{
    public class UnitTest1
    {


        [Theory, AutoData]
        public void GetAllCars_Returns_OkResult(List<Car> cars)
        {
            // Arrange
            var serviceMock = new Mock<ICarService>();
            serviceMock.Setup(service => service.GetAllCars()).Returns(cars);
            var loggerMock = new Mock<ILogger<CarController>>();
            var controller = new CarController(loggerMock.Object, serviceMock.Object);

            // Act
            var result = controller.GetAllCars() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(cars, result.Value);
        }

        [Theory, AutoData]
        public void GetCarsByColor_Returns_OkResult(List<Car> cars, string color)
        {
            // Arrange
            var serviceMock = new Mock<ICarService>();
            serviceMock.Setup(service => service.GetCarsByColor(color)).Returns(cars);
            var loggerMock = new Mock<ILogger<CarController>>();
            var controller = new CarController(loggerMock.Object, serviceMock.Object);

            // Act
            var result = controller.GetCarsByColor(color) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(cars, result.Value);
        }

        [Theory, AutoData]
        public void AddNewCar_Returns_OkResult(Car car)
        {
            // Arrange
            var serviceMock = new Mock<ICarService>();
            var loggerMock = new Mock<ILogger<CarController>>();
            var controller = new CarController(loggerMock.Object, serviceMock.Object);

            // Act
            var result = controller.AddNewCar(car) as OkResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<OkResult>(result);
        }

        [Theory, AutoData]
        public void UpdateCar_Returns_OkResult(int id, Car updatedCar)
        {
            // Arrange
            var serviceMock = new Mock<ICarService>();
            var loggerMock = new Mock<ILogger<CarController>>();
            var controller = new CarController(loggerMock.Object, serviceMock.Object);

            // Act
            var result = controller.UpdateCar(id, updatedCar) as OkResult;

            // Assert
            Assert.NotNull(result);
        }

        [Theory, AutoData]
        public void DeleteCar_Returns_OkResult(int id)
        {
            // Arrange
            var serviceMock = new Mock<ICarService>();
            var loggerMock = new Mock<ILogger<CarController>>();
            var controller = new CarController(loggerMock.Object, serviceMock.Object);

            // Act
            var result = controller.DeleteCar(id) as OkResult;

            // Assert
            Assert.NotNull(result);
        }

    }
}