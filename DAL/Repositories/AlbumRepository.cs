using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicCatalog.Core.Interfaces;
using MusicCatalog.Core.Entities;
using System.Data.SQLite;
using MusicCatalog.Core.Builders;
using System.Xml.Linq;

namespace MusicCatalog.DAL.Repositories
{
    internal class AlbumRepository: IAlbumRepository
    {
        private readonly string _connectionString = "Data Source=MusicCatalog.db; Version=3;";
        private ISongRepository _songRepository = SongRepository.Instance;

        private static AlbumRepository _instance;

        private AlbumRepository() { }

        public static AlbumRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AlbumRepository();
                }
                return _instance;
            }
        }

        public List<Album> SearchByName(string name)
        {
            var albums = new List<Album>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    SELECT *
                    FROM ALBUM 
                    WHERE ALBUM_NAME LIKE @SearchQuery";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchQuery", "%" + name + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var albumName = reader["ALBUM_NAME"].ToString();
                            var albumArtist = reader["ARTIST_NICKNAME"].ToString();
                            var releaseDate = Convert.ToDateTime(reader["RELEASE_DATE"]);

                            var songs = _songRepository.SearchByAlbum(Convert.ToInt32(reader["ID"]));
                            var albumBuilder = new AlbumBuilder();


                            var album = albumBuilder
                                .SetName(albumName)
                                .SetArtistName(albumArtist)
                                .SetReleaseDate(releaseDate)
                                .AddSongs(songs)
                                .Build();

                            albums.Add(album);

                        }
                    }
                }
            }

            return albums;
        }

        public List<Album> SearchByArtistName(string artistName)
        {
            var albums = new List<Album>();
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    SELECT *
                    FROM ALBUM 
                    WHERE ARTIST_NICKNAME LIKE @SearchQuery";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchQuery", "%" + artistName + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var albumName = reader["ALBUM_NAME"].ToString();
                            var albumArtist = reader["ARTIST_NICKNAME"].ToString();
                            var releaseDate = Convert.ToDateTime(reader["RELEASE_DATE"]);

                            var songs = _songRepository.SearchByAlbum(Convert.ToInt32(reader["ID"]));

                            var albumBuilder = new AlbumBuilder();


                            var album = albumBuilder
                                .SetName(albumName)
                                .SetArtistName(albumArtist)
                                .SetReleaseDate(releaseDate)
                                .AddSongs(songs)
                                .Build();

                            albums.Add(album);

                        }
                    }
                }
            }
            return albums;
        }

        public void Add(Album album)
        {
            int albumId;

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    INSERT INTO ALBUM (ALBUM_NAME, ARTIST_NICKNAME) 
                    VALUES (@Name, @ArtistName)
                    RETURNING ID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", album.Name);
                    command.Parameters.AddWithValue("@ArtistName", album.ArtistName);

                    albumId = Convert.ToInt32(command.ExecuteScalar());
                }

                

                foreach (var song in album.Songs)
                {
                    _songRepository.Add(song, albumId);
                }
            }
        }
    }
}
