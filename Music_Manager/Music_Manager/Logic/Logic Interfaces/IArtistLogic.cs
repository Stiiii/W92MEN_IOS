using Microsoft.AspNetCore.Mvc;
using Music_Manager.Models;

namespace Music_Manager.Logic.Logic_Interfaces
{
    public interface IArtistLogic
    {
        //Legalább 5 NON CRUD metódus

        public IEnumerable<Artists> GetAll();
        public Artists GetById(int id);
        public void AddNewArtist([FromBody] Artists artist);
        public void UpdateArtist([FromBody] Artists artist);
        public void DeleteArtist(int id);
    }
}
