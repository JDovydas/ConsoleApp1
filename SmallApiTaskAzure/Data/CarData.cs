using SmallApiTaskAzure.Models;

namespace SmallApiTaskAzure.Data
{
    public class CarData : ICarData
    {
        public List<Car> Cars { get; } = new List<Car>
        {
            new Car { Id = 1, Color = "Green", Make = "Volvo", Year = 1999 },
            new Car { Id = 2, Color = "Red", Make = "Ford", Year = 2000 },
            new Car { Id = 3, Color = "Black", Make = "BMW", Year = 2001 },
            new Car { Id = 4, Color = "Blue", Make = "Nissan", Year = 2002 },

        };

    }
}
