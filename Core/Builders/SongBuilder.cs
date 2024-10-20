using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;

namespace MusicCatalog.Core.Builders
{
    internal class SongBuilder: Ibuilder<Song>
    {
        private readonly Song _song;

        public SongBuilder()
        {
            _song = new Song();
        }

        public SongBuilder SetId(int id)
        {
            _song.Id = id;
            return this;
        }

        public SongBuilder SetName(string name)
        {
            _song.Name = name;
            return this;
        }

        public SongBuilder SetDuration(int duration)
        {
            _song.Duration = duration;
            return this;
        }

        public SongBuilder SetGenre(Genre genre)
        {
            _song.Genre = genre;
            return this;
        }

        public SongBuilder SetAlbumId(int albumId)
        {
            _song.AlbumId = albumId;
            return this;
        }

        public Song Build()
        {
            return _song;
        }
    }
}
