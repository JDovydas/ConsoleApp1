using MiniProject.Data;
using MiniProject.Excepions;
using MiniProject.Model;

namespace MiniProject.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductData _productData;

        public ProductRepository(IProductData productData)
        {
            _productData = productData;
        }

        public IEnumerable<Product> GetAll()
        {
            return _productData.Products;
        }

        public void AddProduct(Product product)
        {

            if (_productData.Products.Any(p => p.Id == product.Id))
            {
                throw new MyCustomException("Product with the same ID already exists");
            }
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            if (string.IsNullOrWhiteSpace(product.Name))
            {
                throw new ArgumentException("Product name cannot be empty.", nameof(product.Name));

            }

            if (product.Price <= 0)
            {
                throw new ArgumentException("Product price must be greater than zero.", nameof(product.Price));
            }

            product.Id = _productData.Products.Count + 1;
            _productData.Products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            var product = _productData.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _productData.Products.Remove(product);
            }
        }

        public void UpdateProduct(int id, Product product)
        {
            var existingProduct = _productData.Products.FirstOrDefault(p => p.Id == id);
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
        }


    }
}
