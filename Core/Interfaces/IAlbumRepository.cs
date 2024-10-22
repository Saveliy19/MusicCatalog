using MusicCatalog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Interfaces
{
    internal interface IAlbumRepository
    {
        public List<Album> SearchByName(string albumName);
        public List<Album> SearchByArtistName(string artistName);

        public void Add(Album album);

    }
}
