using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies.Artists
{
    internal class ArtistSearchContext: ISearchContext<Artist>
    {
        private ISearchStrategy<Artist> _searchStrategy;
        public ArtistSearchContext(ISearchStrategy<Artist> searchStrategy) { _searchStrategy = searchStrategy; }

        public void SetStrategy(ISearchStrategy<Artist> searchStrategy)
        {
            _searchStrategy = searchStrategy;
        }

        public List<Artist> Search(string searchQuery)
        {
            return _searchStrategy.Search(searchQuery);
        }
    }
}
