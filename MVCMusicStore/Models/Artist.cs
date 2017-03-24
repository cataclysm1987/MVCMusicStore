using System.Collections;
using System.Collections.Generic;

namespace MVCMusicStore.Models
{
    public class Artist : IEnumerable
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Artist()
        {
            var Albums = new List<Album>();
        }

        public virtual ICollection<Album> Albums { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}