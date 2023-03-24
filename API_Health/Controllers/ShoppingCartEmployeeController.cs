using API_Health.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Health.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartEmployeeController : ControllerBase
    {
        private readonly APIDbContext _CRUDContext;

        public ShoppingCartEmployeeController(APIDbContext Crudcontex)
        {
            _CRUDContext = Crudcontex;
        }

        // GET: api/ShoppingCartEmployee
        [HttpGet]
        public IEnumerable<ShoppingCartEmployee> Get()
        {
            return _CRUDContext.ShoppingCartEmployee;
        }

        // GET: api/ShoppingCartEmployee/5
        [HttpGet("{id}", Name = "Get1")]
        public ShoppingCartEmployee Get(int id)
        {
            return _CRUDContext.ShoppingCartEmployee.SingleOrDefault(x => x.ID_cart == id);
        }

        // POST: api/ShoppingCartEmployee
        [HttpPost]
        public void Post([FromBody] ShoppingCartEmployee ShoppingCartEmployee)
        {
            _CRUDContext.ShoppingCartEmployee.Add(ShoppingCartEmployee);
            _CRUDContext.SaveChanges();
        }

        // PUT: api/ShoppingCartEmployee/5
        [HttpPut("{id}")]
        public void Put([FromBody] ShoppingCartEmployee ShoppingCartEmployee)
        {
            _CRUDContext.ShoppingCartEmployee.Update(ShoppingCartEmployee);
            _CRUDContext.SaveChanges();
        }

        // DELETE: api/ShoppingCartEmployee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.ShoppingCartEmployee.FirstOrDefault(x => x.ID_cart == id);
            if (item != null)
            {
                _CRUDContext.ShoppingCartEmployee.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}

