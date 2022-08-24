using eShop.Infrastructure.Command.Product;
using eShop.Infrastructure.Event.Product;
using ProductAPI.Repositories;

namespace ProductAPI.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repo;
    
    public ProductService(IProductRepository repo)
    {
        _repo = repo;
    }
    
    public async Task<ProductCreated> GetProduct(Guid productId)
    {
        return await _repo.GetProduct(productId);
    }

    public async Task<ProductCreated> AddProduct(CreateProduct product)
    {
        product.ProductId = Guid.NewGuid();
        return await _repo.AddProduct(product);
    }
}