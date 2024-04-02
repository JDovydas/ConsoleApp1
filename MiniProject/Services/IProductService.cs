using MiniProject.Model;

namespace MiniProject.Services
{
    public interface IProductService
    {

        IEnumerable<Product> GetAllProducts();
        public void AddProduct(Product product);
        void DeleteProduct(int id);
        public void UpdateProduct(int id, Product product);

    }
}
