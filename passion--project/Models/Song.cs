using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace passion__project.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }

        public string SongName { get; set; }

        public string Rating { get; set; }

        //Foreign keys in Entity Framework
        /// https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx

        //A one song is for one artist
        [ForeignKey("Album")]
        public int AlbumID { get; set; }
        public virtual Album Album { get; set; }
    }
    public class SongDto
    {
        public int SongID { get; set; }
        public string SongName { get; set; }
        public string Rating { get; set; }
        public int AlbumID { get; set; }

    }
}