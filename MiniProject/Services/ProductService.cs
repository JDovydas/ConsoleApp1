using MiniProject.Controllers;
using MiniProject.Excepions;
using MiniProject.Model;
using MiniProject.Repositories;
using static MiniProject.Controllers.ProductController;

namespace MiniProject.Services
{

    public class ProductService : IProductService
    {


        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(product.Name))
            {
                throw new ArgumentException("Product name cannot be empty.", nameof(product.Name));
            }

            if (product.Price <= 0)
            {
                throw new ArgumentException("Product price must be greater than zero.", nameof(product.Price));
            }

            _productRepository.AddProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }

        public void UpdateProduct(int id, Product product)
        {
            var existingProduct = _productRepository.GetAll().FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                throw new ArgumentException("Product not found.", nameof(id));
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            _productRepository.UpdateProduct(id, existingProduct);
        }

    }
}
