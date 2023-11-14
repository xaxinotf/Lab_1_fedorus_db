using Lab_1_fedorus_db.Contexts;
using Lab_1_fedorus_db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace Lab_1_fedorus_db.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedMyDbController : ControllerBase
    {
        private readonly BookStoreMongoDbContext _dbContext;


        public FeedMyDbController(BookStoreMongoDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }

        [HttpGet(Name = "Feed")]
        public IActionResult Get()
        {
            int count = 10000;
            for (int i = 0; i < count; i++)
            {
                var order_details = new Order_details
                {
                    
                    CustomerId = i,
                    OrderDate = DateTime.UtcNow, 
                    OrderId = i,
                    OrderDetails = new List<OrderDetail>()
                    {
                        new OrderDetail
                        {
                            
                            BookId = i,
                            Quantity = i
                        }
                    }
                };

                _dbContext.OrderDetails.InsertOne(order_details);
            }
            return Ok();
        }

         
    }

}
