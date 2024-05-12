using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Music_Manager.Logic;
using Music_Manager.Models;
using Music_Manager.Logic.Logic_Interfaces;

namespace Music_Manager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        IArtistLogic logic;

        public ArtistController(IArtistLogic logic)
        {
            this.logic = logic;
        }

        // GET: api/<ArtistController>
        [HttpGet]
        public IEnumerable<Artists> ReadAll()
        {
            return this.logic.GetAll();
        }

        // GET api/<ArtistController>/5
        [HttpGet("{id}")]
        public Artists Read(int id)
        {
            return this.logic.GetById(id);
        }

        // POST api/<ArtistController>
        [HttpPost]
        public void Create([FromBody] Artists value)
        {
            this.logic.AddNewArtist(value);
        }

        // PUT api/<ArtistController>/5
        [HttpPut]
        public void Update([FromBody] Artists value)
        {
            this.logic.UpdateArtist(value);
        }

        // DELETE api/<ArtistController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.logic.DeleteArtist(id);
        }
    }
}
