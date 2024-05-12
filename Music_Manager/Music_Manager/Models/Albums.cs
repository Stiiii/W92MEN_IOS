using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Music_Manager.Models
{
    public class Albums
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AlbumId { get; set; } 

        [Required]
        [StringLength(30)]
        public string AlbumName { get; set; }

        [ForeignKey(nameof(Artists))]
        public int ArtistId { get; set; }

        [JsonIgnore]
        public virtual Ratings? Ratings { get; set; }

        [JsonIgnore]
        public virtual Artists? Artists { get; set; }

        [Required]
        public string? ImageURL { get; set; }

        
        public Albums(int AlbumId, string AlbumName, int ArtistId, string ImageURL)
        {
            this.AlbumId = AlbumId;
            this.AlbumName = AlbumName;
            this.ArtistId = ArtistId;
            this.ImageURL = ImageURL;
        }

        public Albums()
        {
            
        }
    }
}
