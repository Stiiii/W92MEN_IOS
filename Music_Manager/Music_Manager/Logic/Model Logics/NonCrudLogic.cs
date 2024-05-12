using System;
using System.Collections.Generic;
using System.Linq;
using Music_Manager.Models;
using Music_Manager.Repositories.Generic_Repository;

namespace Music_Manager.Logic
{
	public class NonCrudLogic : INonCrudLogic
	{
		IRepository<Artists> artistRep;
		IRepository<Albums> albumRep;
		IRepository<Ratings> ratingRep;

		public NonCrudLogic(IRepository<Artists> artistRep, IRepository<Albums> albumRep, IRepository<Ratings> ratingRep)
		{
			this.artistRep = artistRep;
			this.albumRep = albumRep;
			this.ratingRep = ratingRep;
		}

		public int AlbumCountOfAnArtist(int id)
		{
			if (id > 0 && id <= artistRep.ReadAll().Count())
			{
				return artistRep.ReadAll().Where(t => t.ArtistsId == id).Select(t => t.Albums.Count).FirstOrDefault();
			}
			throw new ArgumentException($"The id that you entered: ({id}) is not acceptable!");
		}

		public IEnumerable<Albums> AlbumsWhereAlbumIdLikeRating()
		{
			return albumRep.ReadAll().Where(t => t.AlbumId == t.Ratings.Rating);
		}

		public IEnumerable<Albums> AlbumsWithExactRatings(double ratingSearch)
		{
			if (ratingSearch > 0 && ratingSearch <= 5)
			{
				return albumRep.ReadAll().Where(t => t.Ratings.Rating == ratingSearch).Select(t => t);
			}
			throw new ArgumentException($"The rating that you entered: ({ratingSearch}) is not acceptable!");
		}

		public IEnumerable<Albums> AlbumsWithMaxRating()
		{
			return albumRep.ReadAll().Where(t => t.Ratings.Rating == 5).Select(t => t);
		}

		public IEnumerable<Artists> ArtistsRatingHigherThanAverage()
		{
			var a = ratingRep.ReadAll().Select(t => t.Rating).Average();
			return albumRep.ReadAll().Where(t => t.Ratings.Rating < a).Select(t => t.Artists).Distinct();
		}

		public Artists ArtistWithMostAlbums()
		{
			return artistRep.ReadAll().OrderByDescending(t => t.Albums.Count).Select(t => t).FirstOrDefault();
		}
	}
}
