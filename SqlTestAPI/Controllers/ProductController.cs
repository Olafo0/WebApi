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
    public class ProductController : ControllerBase
    {
        private readonly SampleDbContext _context;

        public ProductController(SampleDbContext context)
        {
            _context = context;
        }

        // Returns every product 
        [HttpGet]
        public IActionResult AllProducts()
        {

            var all = _context.Products.Where(x => x.ProductId > 0).ToList();


            return Ok(all);
        }

        // Return a specific product 
        [HttpGet("{id}")]
        public IActionResult IdProduct(int id) 
        {

            var SpecificProd = _context.Products.SingleOrDefault(x => x.ProductId == id);

            return Ok(SpecificProd);
        }

        // Delete an item from the database
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {

            var DelProdInv = _context.Inventories.Where(x => x.ProductId == id).ToList();
            var DelList = _context.OrderItems.Where(x => x.ProductId == id).ToList();
            var DelProd = _context.Products.Single(x => x.ProductId == id);

            _context.OrderItems.RemoveRange(DelList);
            _context.Inventories.RemoveRange(DelProdInv);
            _context.Products.Remove(DelProd);
            _context.SaveChanges();

            return Ok();
        }
    }

}

