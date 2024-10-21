using MusicCatalog.Core.Interfaces;
using MusicCatalog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicCatalog.Core.Builders;
using System.Data.SQLite;

namespace MusicCatalog.DAL.Repositories
{
    internal class SongRepository: IRepository<Song>
    {
        private readonly string _connectionString = "Data Source=MusicCatalog.db; Version=3;";

        public List<Song> Search(string searchQuery)
        {
            List<Song> songList = new List<Song>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    SELECT *
                    FROM SONG 
                    WHERE SONG_NAME LIKE @SearchQuery";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var songName = reader["SONG_NAME"].ToString();
                            var songGenre = reader["GENRE_NAME"].ToString();
                            

                            var songBuilder = new SongBuilder();
                            var song = songBuilder
                                    .SetName(songName)
                                    .SetGenre(songGenre)
                                    .Build();

                            songList.Add(song);

                        }
                    }
                }
            }

            return songList;
        }

        public void add(Song song)
        {
            /*using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    INSERT INTO (PLAYLIST_NAME) 
                    VALUES (@PLAYLISTNAME)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PLAYLISTNAME", playList.Name);

                    command.ExecuteNonQuery();
                }
            }*/
        }
    }
}

