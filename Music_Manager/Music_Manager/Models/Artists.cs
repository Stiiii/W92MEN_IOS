using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Music_Manager.Models
{
    public class Artists
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArtistsId { get; set; }

        [Required]
        [StringLength(240)]
        public string ArtistsName { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public virtual ICollection<Albums> Albums { get; set; }

        public Artists()
        {
            Albums = new HashSet<Albums>();
        }

        public Artists(int ArtistsId, string ArtistsName, string Description)
        {
            this.ArtistsId = ArtistsId;
            this.ArtistsName = ArtistsName;
            this.Description = Description;
        }
    }
}
