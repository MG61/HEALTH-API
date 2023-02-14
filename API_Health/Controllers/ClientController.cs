using API_Health.Models;
using Microsoft.AspNetCore.Mvc;


namespace API_Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClientController : ControllerBase
    {
        private readonly APIDbContext _CRUDContext;

        public ClientController(APIDbContext Crudcontex)
        {
            _CRUDContext = Crudcontex;
        }

        // GET: api/Client
       [HttpGet]
         public IEnumerable<Client> Get()
        {
            return _CRUDContext.Clients;
        }

        // GET: api/Client/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            return _CRUDContext.Clients.SingleOrDefault(x => x.ID_client == id);
        }

        // POST: api/Client
        [HttpPost]
        public void Post([FromBody] Client Client)
        {
            _CRUDContext.Clients.Add(Client);
            _CRUDContext.SaveChanges();
        }

        // PUT: api/Client/5
        [HttpPut("{id}")]
        public void Put([FromBody] Client Client)
        {
            _CRUDContext.Clients.Update(Client);
            _CRUDContext.SaveChanges();
        }

        // DELETE: api/Client/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.Clients.FirstOrDefault(x => x.ID_client == id);
            if (item != null)
            {
                _CRUDContext.Clients.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }


    }
}
