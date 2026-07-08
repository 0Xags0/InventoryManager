using InventoryManager.Data;
using InventoryManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace InventoryManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            else
            {
                return Ok(product);
            }
            
        }
        [HttpPost]
        public IActionResult AddProducts(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            var dbProduct = _context.Products.FirstOrDefault(p => p.Id == id);
            if (dbProduct == null)
            {
                return NotFound("Product not found");
            }
            else
            {
                dbProduct.Name = product.Name;
                dbProduct.Brand = product.Brand;
                dbProduct.Description = product.Description;
                dbProduct.Price = product.Price;
                dbProduct.Quantity = product.Quantity;
                _context.SaveChanges();
                return Ok(dbProduct);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var dbProduct = _context.Products.FirstOrDefault(p => p.Id == id);
            if (dbProduct == null)
                return NotFound("Product not found");

            _context.Remove(dbProduct);

            _context.SaveChanges();

            return Ok(dbProduct);
            
        }
    }
}
