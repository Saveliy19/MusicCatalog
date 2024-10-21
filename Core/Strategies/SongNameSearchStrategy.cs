using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies
{
    internal class SongNameSearchStrategy: ISearchStrategy<Song>
    {
        private readonly IRepository<Song> _repository;

        public SongNameSearchStrategy(IRepository<Song> repository) { _repository = repository; }
        public List<Song> Search(string searchQuery)
        {
            return _repository.Search(searchQuery);

        }
    }
}
