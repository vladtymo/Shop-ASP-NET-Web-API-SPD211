using Data;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ShopApi_SPD211.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopDbContext context;

        public ProductsController(ShopDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // OK - 200
            // NotFount - 404
            return Ok(context.Products.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(context.Products.Find(id));
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (!ModelState.IsValid) return NotFound();

            context.Products.Add(model);
            context.SaveChanges();

            return Ok();
        }

        // create
        // edit
        // delete
    }
}
