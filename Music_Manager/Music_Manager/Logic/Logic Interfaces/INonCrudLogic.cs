using System.Collections.Generic;
using Music_Manager.Models;

namespace Music_Manager.Logic
{
	public interface INonCrudLogic
	{
		int AlbumCountOfAnArtist(int id);

		IEnumerable<Albums> AlbumsWithMaxRating();

		Artists ArtistWithMostAlbums();

		IEnumerable<Albums> AlbumsWithExactRatings(double ratingSearch);

		IEnumerable<Artists> ArtistsRatingHigherThanAverage();

		IEnumerable<Albums> AlbumsWhereAlbumIdLikeRating();

	}
}