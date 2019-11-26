using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserMentor.Repository;
using UserMentor.Context;
using UserMentor.Models;

namespace UserMentor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository Repository)
        {
            _repository = Repository;
        }
        // GET: api/User
        [HttpGet]
        [Route("User_GetAll")]
        public List<User> Get()
        {
            return _repository.User_GetAll();
        }
        [HttpGet]
        [Route("User_Search_Mentor/{skill}/{from_timeslot}/{to_timeslot}")]
        public List<Mentor> Get(string skill, string from_timeslot, string to_timeslot)
        {
            return _repository.User_Search_Mentor(skill, from_timeslot, to_timeslot);

        }

        [HttpGet("{id}")]
        [Route("User_Block_Status/{id}")]
        public int Get(long id)
        {
            return _repository.User_Block_status(id);

        }
        // GET: api/User/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/User 
        [HttpPost]
        [Route("User_Add")]
        public IActionResult Post([FromBody] User item)
        {
            _repository.User_Add(item);
            return Ok("User added");
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        [Route("User_Up_Pass/{email}/{pass}")]
        public void Put(string email,string pass)
        {
            _repository.User_Up_password(email, pass);
            
        }

        [HttpPut("{id}")]
        [Route("User_Block/{id}")]
        public string Put(long id)
        {
            _repository.User_Block(id);
            return "blocked";

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("User_Delete/{id}")]
        public string Delete(int id)
        {
            _repository.User_Delete(id);
            return "User Removed";
        }
    }
}
