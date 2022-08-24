using eShop.Infrastructure.Command.Product;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Services;

namespace ProductAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;
    
    public ProductController(IProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get(Guid productId)
    {
        var product = await _service.GetProduct(productId);
        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromForm] CreateProduct product)
    {
        var addedProduct = await _service.AddProduct(product);
        return Ok(addedProduct);
    }
}