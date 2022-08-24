using eShop.Infrastructure.Command.Product;
using eShop.Infrastructure.Event.Product;

namespace ProductAPI.Repositories;

public interface IProductRepository
{
    Task<ProductCreated> GetProduct(Guid productId);

    Task<ProductCreated> AddProduct(CreateProduct product);
}