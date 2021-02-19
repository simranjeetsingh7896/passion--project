using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace passion__project.Models
{
    public class Artist
    {
        [Key]
        public int ArtistID { get; set; }

        public string ArtistName { get; set; }

        //An Artist can have many songs and albums
        public ICollection<Song> Songs { get; set; }
        public ICollection<Album> Albums { get; set; }
    }

    public class ArtistDto
    {
        public int ArtistID { get; set; }

        public string ArtistName { get; set; }

    }
}