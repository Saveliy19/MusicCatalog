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
    internal class SongRepository: ISongRepository
    {
        private readonly string _connectionString = "Data Source=MusicCatalog.db; Version=3;";


        private static SongRepository _instance;

        private SongRepository() { }

        public static SongRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SongRepository();
                }
                return _instance;
            }
        }
        public List<Song> SearchByName(string searchQuery)
        {
            List<Song> songList = new List<Song>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    SELECT 
                        S.SONG_NAME 
                        ,S.GENRE_NAME 
                        ,S.ID AS ID
                        ,A.ALBUM_NAME
                        ,A.ARTIST_NICKNAME
                    FROM 
                    SONG S JOIN ALBUM A
                    ON A.ID = S.ALBUM_ID
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
                            var songId = Convert.ToInt32(reader["ID"]);
                            var albumName = reader["ALBUM_NAME"].ToString();
                            var artistNickname = reader["ARTIST_NICKNAME"].ToString();


                            var songBuilder = new SongBuilder();
                            var song = songBuilder
                                    .SetId(songId)
                                    .SetName(songName)
                                    .SetGenre(songGenre)
                                    .SetAlbumName(albumName)
                                    .SetArtistName(artistNickname)
                                    .Build();

                            songList.Add(song);

                        }
                    }
                }
            }

            return songList;
        }

        public List<Song> SearchByAlbum(int albumId)
        {
            List<Song> songList = new List<Song>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    SELECT 
                        S.SONG_NAME 
                        ,S.GENRE_NAME 
                        ,S.ID AS ID
                        ,A.ALBUM_NAME
                        ,A.ARTIST_NICKNAME
                    FROM 
                    SONG S JOIN ALBUM A
                    ON A.ID = S.ALBUM_ID
                    WHERE S.ALBUM_ID = @SearchQuery";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchQuery", albumId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var songName = reader["SONG_NAME"].ToString();
                            var songGenre = reader["GENRE_NAME"].ToString();
                            var songId = Convert.ToInt32(reader["ID"]);
                            var albumName = reader["ALBUM_NAME"].ToString();
                            var artistNickname = reader["ARTIST_NICKNAME"].ToString();


                            var songBuilder = new SongBuilder();
                            var song = songBuilder
                                    .SetId(songId)
                                    .SetName(songName)
                                    .SetGenre(songGenre)
                                    .SetAlbumName(albumName)
                                    .SetArtistName(artistNickname)
                                    .Build();

                            songList.Add(song);

                        }
                    }
                }
            }

            return songList;
        }

        public List<Song> SearchByGenre(string genreName)
        {
            List<Song> songList = new List<Song>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    SELECT 
                        S.SONG_NAME 
                        ,S.GENRE_NAME 
                        ,S.ID AS ID
                        ,A.ALBUM_NAME
                        ,A.ARTIST_NICKNAME
                    FROM 
                    SONG S JOIN ALBUM A
                    ON A.ID = S.ALBUM_ID
                    WHERE S.GENRE_NAME LIKE @SearchQuery";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchQuery", "%" + genreName + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var songName = reader["SONG_NAME"].ToString();
                            var songGenre = reader["GENRE_NAME"].ToString();
                            var songId = Convert.ToInt32(reader["ID"]);
                            var albumName = reader["ALBUM_NAME"].ToString();
                            var artistNickname = reader["ARTIST_NICKNAME"].ToString();


                            var songBuilder = new SongBuilder();
                            var song = songBuilder
                                    .SetId(songId)
                                    .SetName(songName)
                                    .SetGenre(songGenre)
                                    .SetAlbumName(albumName)
                                    .SetArtistName(artistNickname)
                                    .Build();

                            songList.Add(song);

                        }
                    }
                }
            }

            return songList;
        }


        public List<Song> SearchByPlaylist(int playlistId)
        {
            List<Song> songList = new List<Song>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    SELECT 
                        S.SONG_NAME 
                        ,S.GENRE_NAME 
                        ,S.ID AS ID
                        ,A.ALBUM_NAME
                        ,A.ARTIST_NICKNAME
                    FROM 
                    SONG S JOIN ALBUM A
                    ON A.ID = S.ALBUM_ID
                    JOIN PLAYLIST_SONGS PS
                    ON PS.SONG_ID = SONG.ID
                    WHERE PS.PLAYLIST_ID = @SearchQuery";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchQuery", playlistId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var songName = reader["SONG_NAME"].ToString();
                            var songGenre = reader["GENRE_NAME"].ToString();
                            var songId = Convert.ToInt32(reader["ID"]);
                            var albumName = reader["ALBUM_NAME"].ToString();
                            var artistNickname = reader["ARTIST_NICKNAME"].ToString();


                            var songBuilder = new SongBuilder();
                            var song = songBuilder
                                    .SetId(songId)
                                    .SetName(songName)
                                    .SetGenre(songGenre)
                                    .SetAlbumName(albumName)
                                    .SetArtistName(artistNickname)
                                    .Build();

                            songList.Add(song);

                        }
                    }
                }
            }

            return songList;
        }

        public void Add(Song song, int albumId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                var query = @"
                    INSERT INTO SONG (SONG_NAME, DURATION_SECONDS, ALBUM_ID, GENRE_NAME) 
                    VALUES 
                    (@SongName, @Duration, @AlbumId, @Genre)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SongName", song.Name);
                    command.Parameters.AddWithValue("@Duration", song.Duration);
                    command.Parameters.AddWithValue("@AlbumId", albumId);
                    command.Parameters.AddWithValue("@Genre", song.Genre);
                    command.ExecuteNonQuery();
                }

            }
            
        }
    }
}

