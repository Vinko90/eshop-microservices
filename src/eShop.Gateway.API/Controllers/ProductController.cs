using eShop.Infrastructure.Command.Product;
using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        await Task.CompletedTask;
        return Accepted("Get Product Method called");
    }
    
    [HttpPost]
    public async Task<IActionResult> Get([FromForm] CreateProduct product)
    {
        await Task.CompletedTask;
        return Accepted("Product Created");
    }
}