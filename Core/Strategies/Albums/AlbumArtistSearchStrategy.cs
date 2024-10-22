using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies.Albums
{
    internal class AlbumArtistSearchStrategy
    {
        private readonly IAlbumRepository _repository;

        public AlbumArtistSearchStrategy(IAlbumRepository repository) { _repository = repository; }
        public List<Album> Search(string searchQuery)
        {
            return _repository.SearchByArtistName(searchQuery);
        }
    }
}
