using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Builders
{
    internal class AlbumBuilder: Ibuilder<Album>
    {
        private readonly Album _album;

        public AlbumBuilder() { _album = new Album(); }

        public AlbumBuilder SetId(int id)
        {
            _album.Id = id;
            return this;
        }

        public AlbumBuilder SetName(string name)
        {
            _album.Name = name;
            return this;
        }

        public AlbumBuilder SetReleaseDate(DateTime date)
        {
            _album.ReleaseDate = date;
            return this;
        }

        public AlbumBuilder ArtistId(int id)
        {
            _album.ArtistId = id;
            return this;
        }

        public AlbumBuilder AddSong(Song song)
        {
            _album.Songs.Add(song);
            return this;
        }

        public AlbumBuilder AddSongs(IEnumerable<Song> songs)
        {
            foreach (var song in songs)
            {
                AddSong(song);
            }

            return this;
        }

        public Album Build() { return _album; }


    }
}
