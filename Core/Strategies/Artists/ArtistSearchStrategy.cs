﻿using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Strategies.Artists
{
    internal class ArtistSearchStrategy : ISearchStrategy<Artist>
    {
        private readonly IArtistRepository _repository;

        public ArtistSearchStrategy(IArtistRepository repository) { _repository = repository; }
        public List<Artist> Search(string searchQuery)
        {
            return _repository.SearchByName(searchQuery);
        }
    }
}
