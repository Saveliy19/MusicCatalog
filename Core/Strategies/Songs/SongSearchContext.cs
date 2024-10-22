using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies.Songs
{
    internal class SongSearchContext : ISearchContext<Song>
    {
        private ISearchStrategy<Song> _searchStrategy;

        public SongSearchContext(ISearchStrategy<Song> searchStrategy)
        {
            _searchStrategy = searchStrategy;
        }

        public void SetStrategy(ISearchStrategy<Song> searchStrategy)
        {
            _searchStrategy = searchStrategy;
        }

        public List<Song> Search(string searchQuery)
        {
            return _searchStrategy.Search(searchQuery);
        }
    }
}
