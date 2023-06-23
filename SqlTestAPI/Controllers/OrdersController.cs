using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SqlTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly SampleDbContext _context;

        public OrdersController(SampleDbContext context)
        {
            _context = context;
        }

        // Gets all of the orders in the DB 
        [HttpGet]
        public IActionResult GetallOrders()
        {

            var AllOrders = _context.Orders.Where(x => x.OrderId > 0).ToList();

            return Ok(AllOrders);
        }


        // Gets a specific order
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {

            var GetOrderId = _context.Orders.SingleOrDefault(x => x.OrderId == id);
            return Ok(GetOrderId);
        }

        // Delete from a DB
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {

            var delOrd = _context.Orders.Single(x => x.OrderId == id);
            var delOrdItem = _context.OrderItems.Where(x => x.OrderId == id).ToList();
            _context.OrderItems.RemoveRange(delOrdItem);
            _context.Orders.Remove(delOrd);

            _context.SaveChanges();


            return Ok();
        }


    }
}
