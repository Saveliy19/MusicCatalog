using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Entities
{
    internal class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Genre { get; set; }
        public string AlbumName { get; set; }

        public string ArtistName { get; set; }
    }
}
