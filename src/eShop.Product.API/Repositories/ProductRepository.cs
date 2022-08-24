using eShop.Infrastructure.Command.Product;
using eShop.Infrastructure.Event.Product;
using MongoDB.Driver;

namespace ProductAPI.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly IMongoDatabase _db;
    private readonly IMongoCollection<CreateProduct> _collection;

    public ProductRepository(IMongoDatabase db)
    {
        _db = db;
        _collection = db.GetCollection<CreateProduct>("product");
    }
    
    public async Task<ProductCreated> GetProduct(Guid productId)
    {
        var product = _collection.AsQueryable()
            .FirstOrDefault(x => x.ProductId == productId)!;

        if (product == null)
            throw new Exception("Product not found!");
        
        await Task.CompletedTask;
        
        return new ProductCreated
        {
            ProductId = product.ProductId,
            CreatedAt = DateTime.UtcNow,
            ProductName = product.ProductName
        };
    }

    public async Task<ProductCreated> AddProduct(CreateProduct product)
    {
        await _collection.InsertOneAsync(product);
        
        return new ProductCreated
        {
            ProductId = product.ProductId,
            CreatedAt = DateTime.UtcNow,
            ProductName = product.ProductName
        };
    }
}