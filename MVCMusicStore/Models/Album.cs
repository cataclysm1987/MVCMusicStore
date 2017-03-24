using System.Web.Mvc;

namespace MVCMusicStore.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;


    public enum Genres
    {
        Country,
        Rap,
        Classical,
        Metal,
        Rock,
        Pop,
        Electronic
    }

    public class Album
    {
        public int AlbumId { get; set; }
        public Genres Genre { get; set; }
        public string Title { get; set; }
        public string AlbumArtUrl { get; set; }
        public SelectList ArtistList { get; set; }


        public virtual Artist Artist { get; set; }
    }

    public class MyListTable
    {
        public string Key { get; set; }
        public string Display { get; set; }
    }
}
