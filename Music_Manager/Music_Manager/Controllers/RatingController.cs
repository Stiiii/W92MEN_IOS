using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Music_Manager.Logic;
using Music_Manager.Models;
using Music_Manager.Logic.Logic_Interfaces;

namespace Music_Manager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        IRatingLogic logic;

        public RatingController(IRatingLogic logic)
        {
            this.logic = logic;
        }

        // GET: api/<RatingController>
        [HttpGet]
        public IEnumerable<Ratings> ReadAll()
        {
            return this.logic.GetAll();
        }

        // GET api/<RatingController>/5
        [HttpGet("{id}")]
        public Ratings Read(int id)
        {
            return this.logic.GetById(id);
        }

        // POST api/<RatingController>
        [HttpPost]
        public void Create([FromBody] Ratings value)
        {
            this.logic.AddNewRating(value);
        }

        // PUT api/<RatingController>/5
        [HttpPut]
        public void Update([FromBody] Ratings value)
        {
            this.logic.UpdateRating(value);
        }

        // DELETE api/<RatingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.logic.DeleteRating(id);
        }
    }
}
