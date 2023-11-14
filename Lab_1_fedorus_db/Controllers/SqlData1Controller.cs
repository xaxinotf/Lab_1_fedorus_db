using Lab_1_fedorus_db.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab_1_fedorus_db.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SqlData1Controller : ControllerBase
    {
        private readonly BookStoreDbContext _db;
        public SqlData1Controller(BookStoreDbContext db)
        {
            _db = db;

        }
        [HttpGet(Name = "Feed2")]

        public IActionResult Post()
        {
            int count = 16000;
            for (int i = 0; i < count; i++)
            {
                var orderdetails = new OrderDetail
                {
                    BookId = i,
                    Quantity = i,
                    OrderDetailId = i,
                    OrderId = 1,
                };

                _db.OrderDetails.Add(orderdetails);
                _db.OrderDetails.AddAsync(orderdetails);
                _db.SaveChangesAsync();
            }
            return Ok("14,000 OrderDetail entries have been added.");
        }
    }
}
