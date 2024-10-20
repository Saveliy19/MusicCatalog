using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Builders
{
    internal class ArtistBuilder: Ibuilder<Artist>
    {
        private readonly Artist _artist;
        public ArtistBuilder() { _artist = new Artist();  }

        public ArtistBuilder SetNickname(string nickname)
        {
            _artist.Nickname = nickname;
            return this;
        }

        public ArtistBuilder SetRegistrationDate(DateTime date)
        {
            _artist.RegistrationDate = date;
            return this;
        }

        public ArtistBuilder AddAlbum(Album album)
        {
            _artist.Albums.Add(album);
            return this;
        }

        public ArtistBuilder AddAlbums(IEnumerable<Album> albums)
        {
            foreach (Album album in albums)
            {
                AddAlbum(album);
            }
            return this;
        }

        public Artist Build() { return _artist; }
    }
}
