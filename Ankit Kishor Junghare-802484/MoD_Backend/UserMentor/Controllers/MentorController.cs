using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UserMentor.Models;
using UserMentor.Repository;

namespace UserMentor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;
        public MentorController(IMentorRepository Repository)
        {
            _repository = Repository;
        }
        // GET: api/Mentor
        [HttpGet]
        [Route("Mentor_GetAll")]
        public List<Mentor> Get()
        {
            return _repository.Mentor_GetAll();
        }

        //// GET: api/Mentor/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Mentor
        [HttpPost]
        [Route("Mentor_Add")]
        public IActionResult Post([FromBody] Mentor item)
        {
             _repository.Mentor_Add(item);
            return Ok("Addded result");
        }

        // PUT: api/Mentor/5
        [HttpPut("{id}")]
        [Route("Mentor_Update/{id}")]
        public void Put( [FromBody] Mentor item)
        {
            _repository.Mentor_Update(item);
        }

        [HttpPut("{id}")]
        [Route("Mentor_Block/{id}")]
        public string Put(long id)
        {

            _repository.Mentor_Block(id);
            return "User Blocked";
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("Mentor_Delete/{id}")]

        public string Delete(long id)
        {
            _repository.Mentor_Delete(id);
            return "Mentor Deleted";

        }
    }
}
