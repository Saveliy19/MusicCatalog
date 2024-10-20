using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies
{
    internal class AlbumSearchStrategy: ISearchStrategy<Album>
    {
        private readonly IRepository<Album> _repository;

        public AlbumSearchStrategy(IRepository<Album> repository) { _repository = repository; }
        public List<Album> Search(string searchQuery)
        {
            return _repository.Search(searchQuery);
        }
    }
}
