using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        /*public ActionResult<List<Product>> GetProducts()  {

            return Ok(_context.Products.ToList());
        }*/

        public async Task<ActionResult<List<Product>>> GetProducts() {

            return await _context.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        /*public ActionResult<Product> GetProduct(int id) {
            
            return _context.Products.Find(id);
        }*/

        public async Task<ActionResult<Product>> GetProduct(int id) {
            
            var product = await _context.Products.FindAsync(id);

            return product;
        }
    }
}