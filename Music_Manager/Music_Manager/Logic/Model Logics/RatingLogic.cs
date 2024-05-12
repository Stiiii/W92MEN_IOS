using Microsoft.AspNetCore.Mvc;
using Music_Manager.Logic.Logic_Interfaces;
using Music_Manager.Models;
using Music_Manager.Repositories.Generic_Repository;

namespace Music_Manager.Logic.Model_Logics
{
    public class RatingLogic : IRatingLogic
    {
        IRepository<Ratings> rep;

        public RatingLogic(IRepository<Ratings> rep)
        {
            this.rep = rep;
        }

        public void AddNewRating([FromBody] Ratings rating)
        {
            if (rating.Rating < 1 || rating.Rating > 5 || rating.AlbumId < 0 || rating.AlbumId > rep.ReadAll().Select(t => t.Albums).Count())
            {
                throw new Exception("This rating cannot be created!");
            }
			rep.Create(rating);
        }

        public void DeleteRating(int id)
        {
			if (id < 0 || id > rep.ReadAll().Count())
			{
				throw new ArgumentException($"The id that you entered: ({id}) is not acceptable!");
			}
			rep.Delete(id);
        }

        public IEnumerable<Ratings> GetAll()
        {
            return rep.ReadAll();
        }

        public Ratings GetById(int id)
        {
			if (id < 0 || id > rep.ReadAll().Count())
			{
				throw new ArgumentException($"The id that you entered: ({id}) is not acceptable!");
			}
			return rep.Read(id);
        }

        public void UpdateRating([FromBody] Ratings rating)
        {
			if (rating.Rating < 1 || rating.Rating > 5 || rating.AlbumId < 0 || rating.AlbumId > rep.ReadAll().Select(t => t.Albums).Count())
			{
				throw new Exception("This rating cannot be created!");
			}
			rep.Update(rating);
        }

    }
}
