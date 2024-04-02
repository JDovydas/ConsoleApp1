using MiniProject.Model;

namespace MiniProject.Repositories
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAll();
        public void AddProduct(Product product);
        public void DeleteProduct(int id);
        public void UpdateProduct(int id, Product product);
    }
}
