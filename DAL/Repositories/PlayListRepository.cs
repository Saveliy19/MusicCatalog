using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicCatalog.Core.Entities;
using System.Data.SQLite;
using MusicCatalog.Core.Builders;

namespace MusicCatalog.DAL.Repositories
{
    internal class PlayListRepository: IRepository<PlayList>
    {
        private readonly string _connectionString = "Data Source=MusicCatalog.db; Version=3;";

        public List<PlayList> Search(string searchQuery)
        {
            List<PlayList> playLists = new List<PlayList>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    SELECT *
                    FROM PLAYLIST 
                    WHERE PLAYLIST_NAME LIKE @SearchQuery";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var playListName = reader["PLAYLIST_NAME"].ToString();
                            var playListId = Convert.ToInt32(reader["ID"]);

                            var playlistBuilder = new PlayListBuilder();
                            var playlist = playlistBuilder
                                    .SetName(playListName)
                                    .SetId(playListId)
                                    .Build();

                            playLists.Add(playlist);
                            
                        }
                    }
                }
            }

            return playLists;
        }

        public void add(PlayList playList) 
        {
            int playlistId;
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    INSERT INTO PLAYLIST (PLAYLIST_NAME) 
                    VALUES (@PLAYLISTNAME) 
                    RETURNING ID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PLAYLISTNAME", playList.Name);
                    playlistId = Convert.ToInt32(command.ExecuteScalar());
                }

                query = @"
                    INSERT INTO PLAYLIST_SONGS(SONG_ID, PLAYLIST_ID) 
                    VALUES (@SONGID, @PLAYLISTID)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    foreach (var song in playList.Songs)
                    {
                        
                        command.Parameters.AddWithValue("@SONGID", song.Id);
                        command.Parameters.AddWithValue("@PLAYLISTID", playlistId);
                        command.ExecuteNonQuery();
                    } 
                }
            }
        }
    }
}
