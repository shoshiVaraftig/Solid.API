using Microsoft.AspNetCore.Mvc;
using Solid.Core.Models;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService=productService;
        }
        // private static DataContext _context = new DataContext();
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAll();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            Product p = _productService.GetAll().Find(p=>p.Id == id);
            return p;
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product p)
        {
            int index = 0;
            _productService.GetAll().Add(p);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public Product Put(int id)
        {
            Product p = (_productService.GetAll().Find(p => p.Id == id));
            return p;
        }
        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Product p = _productService.GetAll().Find(p => p.Id == id);
            if (p!=null)
            {
                _productService.GetAll().Remove(p);
            }
            
        }
    }
}
