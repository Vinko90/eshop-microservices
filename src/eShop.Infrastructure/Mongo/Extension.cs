using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace eShop.Infrastructure.Mongo;

public static class Extension
{
    public static void AddMongoDb(this IServiceCollection services, IConfiguration configuration)
    {
        var configSection = configuration.GetSection("Mongo");
        var mongoConfig = new MongoConfig();
        configSection.Bind(mongoConfig);

        services.AddSingleton<IMongoClient>(_ => new MongoClient(mongoConfig.ConnectionString));

        services.AddSingleton<IMongoDatabase>(client =>
        {
            var mongoClient = client.GetService<MongoClient>();
            return mongoClient.GetDatabase(mongoConfig.Database);
        });
    }
}