using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Music_Manager.Logic;
using Music_Manager.Models;
using Music_Manager.Logic.Logic_Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Music_Manager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatController : ControllerBase
    {
        IAlbumLogic albumLogic;
        IArtistLogic artistLogic;
        IRatingLogic ratingLogic;
        INonCrudLogic nonCrudLogic;

        public StatController(IAlbumLogic albumLogic, IArtistLogic artistLogic, IRatingLogic ratingLogic, INonCrudLogic nonCrudLogic)
        {
            this.albumLogic = albumLogic;
            this.artistLogic = artistLogic;
            this.ratingLogic = ratingLogic;
            this.nonCrudLogic = nonCrudLogic;
        }

        
        [HttpGet("AlbumCountOfAnArtist/{id}")]
        public int AlbumCountOfAnArtist(int id)
        {
            return nonCrudLogic.AlbumCountOfAnArtist(id);
        }

		[HttpGet("AlbumsWithMaxRating")]
		public IEnumerable<Albums> AlbumsWithMaxRating()
		{
			return nonCrudLogic.AlbumsWithMaxRating();
		}

        [HttpGet("ArtistsRatingHigherThanAverage")]
		public IEnumerable<Artists> ArtistsRatingHigherThanAverage()
		{
            return nonCrudLogic.ArtistsRatingHigherThanAverage();
		}

        [HttpGet("AlbumsWithExactRatings/{ratingSearch}")]
        public IEnumerable<Albums> AlbumsWithExactRatings(double ratingSearch)
        {
            return nonCrudLogic.AlbumsWithExactRatings(ratingSearch);
        }

		[HttpGet("ArtistWithMostAlbums")]
		public Artists ArtistWithMostAlbums()
		{
			return nonCrudLogic.ArtistWithMostAlbums();
		}
		[HttpGet("AlbumsWhereAlbumIdLikeRating")]
		public IEnumerable<Albums> AlbumsWhereAlbumIdLikeRating()
		{
			return nonCrudLogic.AlbumsWhereAlbumIdLikeRating();
		}
	}
}
