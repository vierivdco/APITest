using APITest.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace APITest.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PeopleController : ControllerBase
    {
        [Authorize]
        [HttpGet(Name = "Get")]
        public IEnumerable<PersonResponse> Get()
        {
            List<PersonResponse> personas = new List<PersonResponse>();
            for (int i = 1; i <= 100; i++)
            {
                PersonResponse persona = new PersonResponse();
                persona.FirstName = "Persona" + i;
                persona.LastName = "Apellido" + i;

                personas.Add(persona);
            }
            return personas;
        }
    }
}
