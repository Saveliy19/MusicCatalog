using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies.Playlists
{
    internal class PlayListSearchStrategy : ISearchStrategy<PlayList>
    {
        private readonly IPlaylistRepository _repository;

        public PlayListSearchStrategy(IPlaylistRepository repository) { _repository = repository; }
        public List<PlayList> Search(string searchQuery)
        {
            return _repository.SearchByName(searchQuery);
        }
    }
}
