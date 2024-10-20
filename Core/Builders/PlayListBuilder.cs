using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Builders
{
    internal class PlayListBuilder: Ibuilder<PlayList>
    {
        private readonly PlayList _playList;

        public PlayListBuilder()
        {
            _playList = new PlayList();
        }
        
        public PlayListBuilder SetId(int id)
        {
            _playList.Id = id;
            return this;
        }

        public PlayListBuilder SetName(string name) 
        { 
            _playList.Name = name;
            return this;
        }

        public PlayListBuilder AddSong(Song song)
        {
            _playList.Songs.Add(song);
            return this;
        }

        public PlayListBuilder AddSongs(IEnumerable<Song> songs)
        {
            foreach (var song in songs)
            {
                AddSong(song);
            }

            return this;
        }
        public PlayList Build() { return _playList; }


    }
}
