using MusicCatalog.Core.Interfaces;
using MusicCatalog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies
{
    internal class SongGenreSearchStrategy: ISearchStrategy<Song>
    {
        private readonly IRepository<Song> _repository;

        public SongGenreSearchStrategy(IRepository<Song> repository) { _repository = repository; }
        public List<Song> Search(string searchQuery)
        {
            var allSongs = _repository.Search("");

            var filteredSongsByGenre = allSongs
            .Where(song => song.Genre.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
            .ToList();

            return filteredSongsByGenre;
        }
    }
}
