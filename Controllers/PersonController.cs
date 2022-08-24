using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2.Model;
using Project2.Service;

namespace Project2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _playerService;

        public PersonController(IPersonService _playerService)
        {
            this._playerService = _playerService;
        }

        [HttpGet("GetAllPerson")]
        public async Task<IEnumerable<Person>> GetAllPerson()
        {
            return _playerService.GetPersonList();
        }
        [HttpGet("{id}")]

        public async Task<Person> GetPersonById(int id)
        {
            var person = await _playerService.GetPersonById(id);
            return person;
        }
        [EnableCors]
        [HttpPost("CreatePerson")]
        
        public async Task<object> CreatePerson([FromBody] Person p)
        {
            
           
                return await _playerService.CreatePerson(p);
         
        }
      
    }
}
