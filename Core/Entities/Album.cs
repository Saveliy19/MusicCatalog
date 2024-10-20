using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Entities
{
    internal class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        public string ArtistName { get; set; }
        public List<Song> Songs { get; set; }
    }
}
