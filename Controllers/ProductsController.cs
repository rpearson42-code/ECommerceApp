using ECommerceApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        //GET: api/Products
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            return new Products[]
            {
                new Products { Id = 1, Name = "Laptop", Description = "A high-performance laptop", Price = 999.99m },
                new Products { Id = 2, Name = "Smartphone", Description = "A latest model smartphone", Price = 499.99m },
                new Products { Id = 3, Name = "Headphones", Description = "Noise-cancelling headphones", Price = 199.99m }
            };
        }
    }
}
