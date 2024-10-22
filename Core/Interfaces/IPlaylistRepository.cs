using MusicCatalog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Interfaces
{
    internal interface IPlaylistRepository
    {
        public List<PlayList> SearchByName(string playlistName);

        public void Add(PlayList playList);
    }
}
