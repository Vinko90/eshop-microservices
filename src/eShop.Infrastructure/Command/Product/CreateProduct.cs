using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace eShop.Infrastructure.Command.Product;

public class CreateProduct
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public object _Id { get; set; }
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
    
    public string ProductDescription { get; set; }
    
    public float ProductPrice { get; set; }
    
    public Guid CategoryId { get; set; }
}