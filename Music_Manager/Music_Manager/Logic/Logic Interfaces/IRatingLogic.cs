using Microsoft.AspNetCore.Mvc;
using Music_Manager.Models;

namespace Music_Manager.Logic.Logic_Interfaces
{
    public interface IRatingLogic
    {
        public IEnumerable<Ratings> GetAll();
        public Ratings GetById(int id);
        public void AddNewRating([FromBody] Ratings rating);
        public void UpdateRating([FromBody] Ratings rating);
        public void DeleteRating(int id);
    }
}
