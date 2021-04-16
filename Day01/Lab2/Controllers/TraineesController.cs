using Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Model_Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineesController : ControllerBase
    {
        TraineeDbContext traineeDbContext ;
        public TraineesController (TraineeDbContext _traineeDbContext)
        {
            this.traineeDbContext = _traineeDbContext;
        }
         // GET: api/<TraineesController>
         [HttpGet]
        public IEnumerable<Trainee> Get()
        {
            return traineeDbContext.Trainees.ToList();
        }

        // GET api/<TraineesController>/5
        [HttpGet("{id}")]
        public Trainee Get(int id)
        {
            Trainee trainee = traineeDbContext.Trainees.ToList().FirstOrDefault(t => t.Trainee_ID == id);
            return trainee;
        }

        // POST api/<TraineesController>
        [HttpPost]
        public void Post([FromBody] Trainee trainee)
        {
            traineeDbContext.Trainees.Add(trainee);
            traineeDbContext.SaveChanges();
        }

        // PUT api/<TraineesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Trainee trainee)
        {
            traineeDbContext.Update(trainee);
            traineeDbContext.SaveChanges();
        }

        // DELETE api/<TraineesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Trainee trainee = traineeDbContext.Trainees.ToList().FirstOrDefault(t => t.Trainee_ID == id);
            traineeDbContext.Trainees.Remove(trainee);
            traineeDbContext.SaveChanges();
        }
    }
}
