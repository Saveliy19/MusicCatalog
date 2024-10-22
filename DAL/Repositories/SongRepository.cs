using MusicCatalog.Core.Builders;
using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System.Data.SQLite;

namespace MusicCatalog.DAL.Repositories
{
    internal class SongRepository : ISongRepository
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
            return SearchSongs("SONG_NAME", searchQuery, isLike: true);
        }

        public List<Song> SearchByAlbum(int albumId)
        {
            return SearchSongs("S.ALBUM_ID", albumId.ToString(), isLike: false);
        }

        public List<Song> SearchByGenre(string genreName)
        {
            return SearchSongs("S.GENRE_NAME", genreName, isLike: true);
        }

        public List<Song> SearchByPlaylist(int playlistId)
        {
            return SearchSongs("PS.PLAYLIST_ID", playlistId.ToString(), isLike: false, isJoinPlaylist: true);
        }

        private List<Song> SearchSongs(string searchField, string searchTerm, bool isLike, bool isJoinPlaylist = false)
        {
            var songList = new List<Song>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    SELECT 
                        S.SONG_NAME,
                        S.GENRE_NAME,
                        S.ID AS ID,
                        S.DURATION_SECONDS,
                        A.ALBUM_NAME,
                        A.ARTIST_NICKNAME
                    FROM 
                        SONG S 
                    JOIN 
                        ALBUM A ON A.ID = S.ALBUM_ID ";

                if (isJoinPlaylist)
                {
                    query += "JOIN PLAYLIST_SONGS PS ON PS.SONG_ID = S.ID ";
                }

                query += $"WHERE {searchField} {(isLike ? "LIKE" : "=")} @SearchQuery";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchQuery", isLike ? "%" + searchTerm + "%" : searchTerm);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var songName = reader["SONG_NAME"].ToString();
                            var songGenre = reader["GENRE_NAME"].ToString();
                            var songId = Convert.ToInt32(reader["ID"]);
                            var albumName = reader["ALBUM_NAME"].ToString();
                            var artistNickname = reader["ARTIST_NICKNAME"].ToString();
                            var duration = Convert.ToInt32(reader["DURATION_SECONDS"]);

                            var songBuilder = new SongBuilder();
                            var song = songBuilder
                                .SetId(songId)
                                .SetName(songName)
                                .SetGenre(songGenre)
                                .SetAlbumName(albumName)
                                .SetArtistName(artistNickname)
                                .SetDuration(duration)
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
