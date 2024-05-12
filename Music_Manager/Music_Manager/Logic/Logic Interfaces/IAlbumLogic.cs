using Microsoft.AspNetCore.Mvc;
using Music_Manager.Models;

namespace Music_Manager.Logic.Logic_Interfaces
{
    public interface IAlbumLogic
    {
        public IEnumerable<Albums> GetAll();
        public Albums GetById(int id);
        public void AddNewAlbum([FromBody] Albums album);
        public void UpdateAlbum([FromBody] Albums album);
        public IEnumerable<Albums> Search([FromBody] string name);
        public void DeleteAlbum(int id);
    }
}
