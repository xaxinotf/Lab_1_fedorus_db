using Lab_1_fedorus_db.Models;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace Lab_1_fedorus_db.Contexts;

public class BookStoreMongoDbContext 
{
    private readonly IMongoDatabase _database;

    public BookStoreMongoDbContext(IMongoClient client, string databaseName)
    {
        _database = client.GetDatabase(databaseName);
    }
    public IMongoCollection<Order_details> OrderDetails => _database.GetCollection<Order_details>("order_details");
}