using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies.Playlists
{
    internal class PlaylistSearchContext: ISearchContext<PlayList>
    {
        private ISearchStrategy<PlayList> _searchStrategy;

        public PlaylistSearchContext(ISearchStrategy<PlayList> searchStrategy)
        {
            _searchStrategy = searchStrategy;
        }

        public void SetStrategy(ISearchStrategy<PlayList> searchStrategy)
        {
            _searchStrategy = searchStrategy;
        }

        public List<PlayList> Search(string searchQuery)
        {
            return _searchStrategy.Search(searchQuery);
        }
    }
}
