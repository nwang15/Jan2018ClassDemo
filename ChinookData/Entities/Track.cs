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

    [Table("Tracks")]
    public class Track
    {
        [Key]

        public int TrackId { get; set; }

        //[Required(ErrorMessage = "Name is requires"];
        [StringLength(200, ErrorMessage = "Tracks Name has a maximum of 200 characters")]
        public string Name { get; set; }
        public int? AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public int? GenreId { get; set; }

        [StringLength(220, ErrorMessage = "Composer Name has a maximum of 220 characters")]
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public int? Bytes { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Album Albums { get; set; }
    }
}
