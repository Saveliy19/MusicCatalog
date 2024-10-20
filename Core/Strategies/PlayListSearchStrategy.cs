using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies
{
    internal class PlayListSearchStrategy : ISearchStrategy<PlayList>
    {
        private readonly IRepository<PlayList> _repository;

        public PlayListSearchStrategy(IRepository<PlayList> repository) { _repository = repository; }
        public List<PlayList> Search(string searchQuery)
        {
            return _repository.Search(searchQuery);
        }
    }
}
