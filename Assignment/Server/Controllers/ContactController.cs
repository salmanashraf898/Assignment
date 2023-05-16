using Assignment.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact { Id = 1, Name = "Salman", Email = "test1", Phone = 123 });
            contacts.Add(new Contact { Id = 2, Name = "Ali", Email = "test2", Phone = 123 });
            contacts.Add(new Contact { Id = 3, Name = "Abdullah", Email = "test3", Phone = 123 });
            return contacts;    
        }

    }
}
