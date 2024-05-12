using Microsoft.AspNetCore.Mvc;
using Music_Manager.Logic.Logic_Interfaces;
using Music_Manager.Models;
using Music_Manager.Repositories.Generic_Repository;

namespace Music_Manager.Logic.Model_Logics
{
    public class AlbumLogic : IAlbumLogic
    {
        IRepository<Albums> rep;

        public AlbumLogic(IRepository<Albums> rep)
        {
            this.rep = rep;
        }

        public void AddNewAlbum([FromBody] Albums album)
        {
            if (album.AlbumName == "" || album.AlbumName == string.Empty)
            {
				throw new ArgumentException("The name of the artist can't be empty!");
			}
			if (album.ArtistId < 0 || album.ArtistId > rep.ReadAll().Select(t => t.Artists).Count())
			{
				throw new ArgumentException($"This album cannot be created!");
			}
			else
            {
                rep.Create(album);
            }
        }

        public void DeleteAlbum(int id)
        {
            if (id < 0 )
            {
				throw new ArgumentException($"The id that you entered: ({id}) is not acceptable!");
			}
            if (rep.Read(id) == null)
            {
				throw new ArgumentException($"The id that you entered: ({id}) is not acceptable!");
			}
			rep.Delete(id);
		}

        public IEnumerable<Albums> GetAll()
        {
            return rep.ReadAll();
        }

        public IEnumerable<Albums> Search([FromBody] string name)
        {
            return rep.ReadAll().Where(t => t.AlbumName.ToUpper().Contains(name.ToUpper()));
        }

        public Albums GetById(int id)
        {
			if (id < 0 || id > rep.ReadAll().Count())
			{
				throw new ArgumentException($"The id that you entered: ({id}) is not acceptable!");
			}
			return rep.Read(id);
        }

        public void UpdateAlbum([FromBody] Albums album)
        {
			if (album.AlbumName == "" || album.AlbumName == string.Empty)
			{
				throw new ArgumentException("The name of the artist can't be empty!");
			}
			if (album.ArtistId < 0 || album.ArtistId > rep.ReadAll().Select(t => t.Artists).Count())
			{
				throw new ArgumentException($"This album cannot be created!");
			}
			rep.Update(album);
        }
    }
}
