using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController:ControllerBase
    {
        private readonly SampleDbContext _context;

        public InventoryController(SampleDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AllWarehouse()
        {

            var allwarehouse = _context.Inventories.Where(x => x.ProductId > 0).ToList();

            return Ok(allwarehouse);

        }

        [HttpGet("{id}")]
        public IActionResult GetWarehouse(int id)
        {
            var warehousestock = _context.Inventories.Where(x => x.ProductId == id).ToList();
            return Ok(warehousestock);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWarehouse(int id)
        {
            var delete = _context.Inventories.Where(x => x.ProductId == id).ToList();
            _context.Inventories.RemoveRange(delete);
            _context.SaveChanges();

            return Ok("W mans");



        }




    }
}
