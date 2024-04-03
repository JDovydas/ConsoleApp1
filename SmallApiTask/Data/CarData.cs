using SmallApiTask.Models;

namespace SmallApiTask.Data
{
    public class CarData : ICarData
    {
        public List<CarDto> Cars { get; } = new List<CarDto>
        {
            new CarDto { Id = 1, Color = "Green", Make = "Volvo", Year = 1999 },
            new CarDto { Id = 2, Color = "Red", Make = "Ford", Year = 2000 },
            new CarDto { Id = 3, Color = "Black", Make = "BMW", Year = 2001 },
            new CarDto { Id = 4, Color = "Blue", Make = "Nissan", Year = 2002 },

        };

    }
}
