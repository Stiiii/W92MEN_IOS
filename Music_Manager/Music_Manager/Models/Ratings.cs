using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Music_Manager.Models
{
    public class Ratings
    {
        public Ratings()
        {
        }

        public Ratings(int ratingId, int albumId, double rating)
        {
            RatingId = ratingId;
            AlbumId = albumId;
            Rating = rating;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RatingId { get; set; }      
        public double Rating { get; set; }

        [ForeignKey(nameof(Albums))]
        public int AlbumId { get; set; }

        [JsonIgnore]
        public virtual Albums Albums { get; set; }

    }
}
