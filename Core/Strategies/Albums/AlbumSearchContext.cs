using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies.Albums
{
    internal class AlbumSearchContext: ISearchContext<Album>
    {
        private ISearchStrategy<Album> _searchStrategy;

        public AlbumSearchContext(ISearchStrategy<Album> searchStrategy)
        {
            _searchStrategy = searchStrategy;
        }

        public void SetStrategy(ISearchStrategy<Album> searchStrategy)
        {
            _searchStrategy = searchStrategy;
        }

        public List<Album> Search(string searchQuery)
        {
            return _searchStrategy.Search(searchQuery);
        }
    }
}
