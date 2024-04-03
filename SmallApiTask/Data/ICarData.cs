using SmallApiTask.Models;

namespace SmallApiTask.Data
{
    public interface ICarData
    {
        public List<CarDto> Cars { get; }
    }
}
