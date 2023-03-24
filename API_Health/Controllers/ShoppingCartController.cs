using API_Health.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly APIDbContext _CRUDContext;

        public ShoppingCartController(APIDbContext Crudcontex)
        {
            _CRUDContext = Crudcontex;
        }

        // GET: api/ShoppingCart
        [HttpGet]
        public IEnumerable<ShoppingCart> Get()
        {
            return _CRUDContext.ShoppingCarts;
        }

        // GET: api/ShoppingCart/5
        [HttpGet("{id}", Name = "Get")]
        public ShoppingCart Get(int id)
        {
            return _CRUDContext.ShoppingCarts.SingleOrDefault(x => x.ID_cart == id);
        }

        // POST: api/ShoppingCart
        [HttpPost]
        public void Post([FromBody] ShoppingCart ShoppingCart)
        {
            _CRUDContext.ShoppingCarts.Add(ShoppingCart);
            _CRUDContext.SaveChanges();
        }

        // PUT: api/ShoppingCart/5
        [HttpPut("{id}")]
        public void Put([FromBody] ShoppingCart ShoppingCart)
        {
            _CRUDContext.ShoppingCarts.Update(ShoppingCart);
            _CRUDContext.SaveChanges();
        }

        // DELETE: api/ShoppingCart/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.ShoppingCarts.FirstOrDefault(x => x.ID_cart == id);
            if (item != null)
            {
                _CRUDContext.ShoppingCarts.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}
