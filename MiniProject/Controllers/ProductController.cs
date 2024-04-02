using Microsoft.AspNetCore.Mvc;
using MiniProject.Model;
using MiniProject.Services;

namespace MiniProject.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = _productService.GetAllProducts();
        return Ok(products);
    }

    [HttpPost]
    public IActionResult AddProduct(Product product)
    {

        _productService.AddProduct(product);
        return CreatedAtAction(nameof(GetProducts), product);
    }

    [HttpDelete("{id}")]
    public void DeleteProduct(int id)
    {
        _productService.DeleteProduct(id);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, Product product)
    {
        try
        {
            _productService.UpdateProduct(id, product);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


}




