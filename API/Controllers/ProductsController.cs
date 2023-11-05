using Core.Entities;
using Infastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {

        private readonly StoreContext _context;
        public ProductsController(StoreContext context) //This is depedency injection based on Program.cs
        {
            _context= context;
        }

       
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() //We use task, so that it can async so that it is mroe scaleable Best practice to use task as well. 
        {
            var products = await _context.Products.ToListAsync();

            return products;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}