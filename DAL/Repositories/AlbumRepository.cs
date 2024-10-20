﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicCatalog.Core.Interfaces;
using MusicCatalog.Core.Entities;
using System.Data.SQLite;
using MusicCatalog.Core.Builders;

namespace MusicCatalog.DAL.Repositories
{
    internal class AlbumRepository: IRepository<Album>
    {
        private readonly string _connectionString = "Data Source=MusicCatalog.db; Version=3;";

        public List<Album> Search(string searchQuery)
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
                    command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var albumName = reader["ALBUM_NAME"].ToString();
                            var albumArtist = reader["ARTIST_NICKNAME"].ToString();
                            var releaseDate = Convert.ToDateTime(reader["RELEASE_DATE"]);


                            var albumBuilder = new AlbumBuilder();


                            var album = albumBuilder
                                .SetName(albumName)
                                .SetArtistName(albumArtist)
                                .SetReleaseDate(releaseDate)
                                .Build();

                            albums.Add(album);

                        }
                    }
                }
            }

            return albums;
        }

        public void add(Album album)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    INSERT INTO ALBUM (ALBUM_NAME, ARTIST_NICKNAME) 
                    VALUES (@Name, @ArtistName)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", album.Name);
                    command.Parameters.AddWithValue("@ArtistName", album.ArtistName);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
