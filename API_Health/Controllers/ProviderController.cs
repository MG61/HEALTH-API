using API_Health.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly APIDbContext _CRUDContext;

        public ProviderController(APIDbContext Crudcontex)
        {
            _CRUDContext = Crudcontex;
        }

        // GET: api/Provider
        [HttpGet]
        public IEnumerable<Provider> Get()
        {
            return _CRUDContext.Providers;
        }

        // GET: api/Provider/5
        [HttpGet("{id}")]
        public Provider Get(int id)
        {
            return _CRUDContext.Providers.SingleOrDefault(x => x.ID_provider == id);
        }

        // POST: api/Provider
        [HttpPost]
        public void Post([FromBody] Provider Provider)
        {
            _CRUDContext.Providers.Add(Provider);
            _CRUDContext.SaveChanges();
        }

        // PUT: api/Provider/5
        [HttpPut("{id}")]
        public void Put([FromBody] Provider Provider)
        {
            _CRUDContext.Providers.Update(Provider);
            _CRUDContext.SaveChanges();
        }

        // DELETE: api/Provider/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.Providers.FirstOrDefault(x => x.ID_provider == id);
            if (item != null)
            {
                _CRUDContext.Providers.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}
