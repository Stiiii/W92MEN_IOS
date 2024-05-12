using Microsoft.AspNetCore.Mvc;
using Music_Manager.Logic.Logic_Interfaces;
using Music_Manager.Models;
using Music_Manager.Repositories.Generic_Repository;

namespace Music_Manager.Logic.Model_Logics
{
    public class ArtistLogic : IArtistLogic
    {
        IRepository<Artists> rep;

        public ArtistLogic(IRepository<Artists> rep)
        {
            this.rep = rep;
        }

        public void AddNewArtist([FromBody] Artists artist)
        {
            if (artist.ArtistsName == "" || artist.ArtistsName == null)
            {
                throw new ArgumentException("The name of the artist can't be empty!");
            }
            rep.Create(artist);
        }

        public void DeleteArtist(int id)
        {
            if (id < 0 || id > rep.ReadAll().Count())
            {
				throw new ArgumentException($"The id that you entered: ({id}) is not acceptable!");
			}
            rep.Delete(id);
        }

        public IEnumerable<Artists> GetAll()
        {
            return rep.ReadAll();
        }

        public Artists GetById(int id)
        {
			if (id < 0 || id > rep.ReadAll().Count())
			{
				throw new ArgumentException($"The id that you entered: ({id}) is not acceptable!");
			}
			return rep.Read(id);
        }

        public void UpdateArtist([FromBody] Artists artist)
        {
			if (artist.ArtistsName == "" || artist.ArtistsName == null)
			{
				throw new ArgumentException("The name of the artist can't be empty!");
			}
			rep.Update(artist);
        }
    }
}
