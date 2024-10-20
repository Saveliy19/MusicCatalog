using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies
{
    internal class ArtistSearchStrategy: ISearchStrategy<Artist>
    {
        private readonly IRepository<Artist> _repository;

        public ArtistSearchStrategy(IRepository<Artist> repository) { _repository = repository; }
        public List<Artist> Search(string searchQuery)
        {
            return _repository.Search(searchQuery);
        }
    }
}
