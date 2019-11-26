using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using TechnologyService.Models;
using TechnologyService.Repository;

namespace TechnologyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillsRepository _repository;
        public SkillsController(ISkillsRepository Repository)
        {
            _repository = Repository;


        }
        // GET: api/Skills
        [HttpGet]
        [Route("Skills_GetAll")]
        public List<Skills> Get()
        {
            return _repository.Skills_GetAll();
        }

        //// GET: api/Skills/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        [HttpPost]

        [Route("Skills_Add")]
        public IActionResult Post( Skills item)
        {
            _repository.Skills_Add(item);
            return Ok();
        }

        // POST: api/Skills
        [HttpPost]
        public void Post( string value)
        {
        }

        [HttpPut("{id}")]
        [Route("Skills_Update/{id}")]
        public IActionResult Put([FromBody] Skills item)
        {
            _repository.Skills_Update(item);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
