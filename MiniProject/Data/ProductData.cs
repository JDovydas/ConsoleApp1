using MiniProject.Model;

namespace MiniProject.Data
{
    public class ProductData : IProductData
    {
        public List<Product> Products { get; } = new List<Product>
        {
                new Product {Id = 1, Name = "P1", Price = 10},
                new Product {Id = 2, Name = "P2", Price = 100},
                new Product {Id = 3, Name = "P3", Price = 1000}
        };

    }
}
