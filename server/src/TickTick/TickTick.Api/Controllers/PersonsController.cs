using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TickTick.Models;

namespace TickTick.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public IActionResult get()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 5; i++) 
            {
                Person person = new Person("Briek", "Keters", "briek.keters@gmail.com") { Id = (ulong)i};
                people.Add(person);
            }
            return Ok(people);
        }

        [HttpGet("{id}")]
        public IActionResult get(Guid id)
        {
            //TODO: haal een persoon op
            Person person = new Person("Briek", "Keters", "briek.keters@gmail.com");
            return Ok(person);
        }
    }
}
