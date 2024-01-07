using Microsoft.AspNetCore.Mvc;
using Solid.Core.Models;
using Solid.Core.Services;
using Solid.Service.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastomersController : ControllerBase
    {

        private readonly ICustomerService _customerService;
        public CastomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerService.GetAll();
        }

        // GET api/<CastomersController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            Customer c = _customerService.GetAll().Find(c => c.Id == id);
            return c;
        }

        // POST api/<CastomersController>
        [HttpPost]
        public void Post([FromBody] Customer c1)
        {
            _customerService.GetAll().Add(new Customer { Id = c1.Id });
        }

        // PUT api/<CastomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer c)
        {
            _customerService.GetAll()[id - 1] = c;
            _customerService.GetAll()[id - 1].Id = id;
        }

        // DELETE api/<CastomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerService.GetAll().Remove(_customerService.GetAll()[id - 1]);
        }
    }
}
