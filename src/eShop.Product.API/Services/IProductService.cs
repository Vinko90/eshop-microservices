using eShop.Infrastructure.Command.Product;
using eShop.Infrastructure.Event.Product;

namespace ProductAPI.Services;

public interface IProductService
{
    Task<ProductCreated> GetProduct(Guid productId);

    Task<ProductCreated> AddProduct(CreateProduct product);
}