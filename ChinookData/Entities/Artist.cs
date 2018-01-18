using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#endregion
namespace Chinook.Data.Entities
{
    [Table("Artists")]
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        [Required(ErrorMessage ="Artist Name is required.")]
        [StringLength(120, ErrorMessage ="Artists Name has a maximum of 120 characters")]
        public string Name { get; set; }

        // navigational properities

        public virtual ICollection<Album> Ablums { get; set; }
    }
}
