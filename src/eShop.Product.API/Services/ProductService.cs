using eShop.Infrastructure.Command.Product;
using eShop.Infrastructure.Event.Product;

namespace ProductAPI.Services;

public class ProductService : IProductService
{
    public Task<ProductCreated> GetProduct(Guid productId)
    {
        throw new NotImplementedException();
    }

    public Task<ProductCreated> AddProduct(CreateProduct product)
    {
        throw new NotImplementedException();
    }
}