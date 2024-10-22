using MusicCatalog.Core.Interfaces;
using MusicCatalog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies.Songs
{
    internal class SongGenreSearchStrategy : ISearchStrategy<Song>
    {
        private readonly ISongRepository _repository;

        public SongGenreSearchStrategy(ISongRepository repository) { _repository = repository; }
        public List<Song> Search(string searchQuery)
        {
            List<Song> songs = _repository.SearchByGenre(searchQuery);

            return songs;
        }
    }
}
