using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Music_Manager.Logic;
using Music_Manager.Models;
using Music_Manager.Logic.Logic_Interfaces;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Music_Manager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        IAlbumLogic logic;

        public AlbumController(IAlbumLogic logic)
        {
            this.logic = logic;
        }

        // GET: api/<AlbumController>
        [HttpGet]
        //[Authorize]
        public IEnumerable<Albums> ReadAll()
        {
            return this.logic.GetAll();
        }

        [HttpGet("search/{name}")]
        public IEnumerable<Albums> Search(string name)
        {
            return this.logic.Search(name);
        }


        // GET api/<AlbumController>/5
        [HttpGet("{id}")]
        public Albums Read(int id)
        {
            return this.logic.GetById(id);
        }

        // POST api/<AlbumController>
        [HttpPost]
        public void Create([FromBody] Albums value)
        {
            this.logic.AddNewAlbum(value);
        }

        // PUT api/<AlbumController>/5
        [HttpPut]
        public void Update([FromBody] Albums value)
        {
            this.logic.UpdateAlbum(value);
        }

        // DELETE api/<AlbumController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.logic.DeleteAlbum(id);
        }
    }
}
