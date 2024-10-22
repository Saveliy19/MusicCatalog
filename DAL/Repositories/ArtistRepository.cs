using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using MusicCatalog.Core.Builders; 
using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;

namespace MusicCatalog.DAL.Repositories
{
    internal class ArtistRepository: IArtistRepository
    {
        private readonly string _connectionString = "Data Source=MusicCatalog.db; Version=3;";

        private static ArtistRepository _instance;

        private ArtistRepository() { }

        public static ArtistRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ArtistRepository();
                }
                return _instance;
            }
        }
        public List<Artist> SearchByName(string searchQuery)
        {
            var artists = new List<Artist>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    SELECT *
                    FROM ARTIST 
                    WHERE NICKNAME LIKE @SearchQuery";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var artistNickname = reader["NICKNAME"].ToString();
                            var registrationDate = Convert.ToDateTime(reader["REGISTRATION_DATE"]);

                            var artistBuilder = new ArtistBuilder();
                            var artist = artists.FirstOrDefault(a => a.Nickname == artistNickname);

                            if (artist == null)
                            {
                                artist = artistBuilder
                                    .SetNickname(artistNickname)
                                    .SetRegistrationDate(registrationDate)
                                    .Build();

                                artists.Add(artist);
                            }
                        }
                    }
                }
            }

            return artists;
        }

        public void Add(Artist artist)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    INSERT INTO ARTIST (NICKNAME, REGISTRATION_DATE) 
                    VALUES (@Nickname, @RegistrationDate)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nickname", artist.Nickname);
                    command.Parameters.AddWithValue("@RegistrationDate", artist.RegistrationDate);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
