using MusicCatalog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Interfaces
{
    internal interface ISongRepository
    {
        public List<Song> SearchByName(string songName);
        public List<Song> SearchByGenre(string genreName);

        public List<Song> SearchByAlbum(int albumId);

        public List<Song> SearchByPlaylist(int playlistId);

        public void Add(Song song, int playlistId);
    }
}
