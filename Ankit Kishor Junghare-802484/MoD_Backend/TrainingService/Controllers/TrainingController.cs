using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingService.Repository;
using TrainingService.Context;
using TrainingService.Models;

namespace TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository _repository;
        public TrainingController(ITrainingRepository Repository)
        {
            _repository = Repository;

            
        }
        // GET: api/Training
        [HttpGet]
        [Route("Training_GetAll")]
        public List<Training> Get()
        {
            return _repository.Training_GetAll();
        }

        // GET: api/Training/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Training
        [HttpPost]

        [Route("Training_Add")]
        public IActionResult Post( Training item)
        {
            _repository.Training_Add(item);
            return Ok();
        }
       
        [HttpPut("{id}")]
        [Route("Training_Update/{id}")]
        public IActionResult Put( Models.Training item)
        {
            _repository.Training_Update(item);
            return Ok();
        }

        // PUT: api/Training/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
