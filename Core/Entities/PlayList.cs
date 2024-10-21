using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Entities
{
    internal class PlayList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }

        public PlayList()
        {
            Songs = new List<Song>();
        }
    }
}
