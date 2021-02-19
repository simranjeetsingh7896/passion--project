using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace passion__project.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }

        public string AlbumName { get; set; }

        public string Rating { get; set; }

        //Foreign keys in Entity Framework
        /// https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx

        //A one song is for one artist
        [ForeignKey("Artist")]
        public int ArtistID { get; set; }
        public virtual Artist Artist { get; set; }
    }
    public class AlbumDto
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public string Rating { get; set; }
        public int ArtistID { get; set; }


    }
}