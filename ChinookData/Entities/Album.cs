﻿using System;
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
    [Table("Albums")]
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        [StringLength(160, ErrorMessage = "Album Title has a maximum of 160 characters")]
        public string Title { get; set; }

        public int ArtistId { get; set; }

        public int ReleaseYear { get; set; }

        [StringLength(50, ErrorMessage = "Release Label has a maximum of 50 characters")]
        public string ReleaseLabel { get; set; }

        public virtual Artist Artists { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
