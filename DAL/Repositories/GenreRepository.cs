using MusicCatalog.Core.Builders;
using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.DAL.Repositories
{
    internal class GenreRepository
    {
        private readonly string _connectionString = "Data Source=MusicCatalog.db; Version=3;";

        private static GenreRepository _instance;

        private GenreRepository() { }

        public static GenreRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GenreRepository();
                }
                return _instance;
            }
        }

        public List<Genre> Search(string? searchQuery) 
        {
            List<Genre> genres = new List<Genre>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var query = @"
                    SELECT *
                    FROM GENRE
                    ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var genreName = reader["GENRE_NAME"].ToString();
                            

                            Genre genre = new Genre();
                            genre.GenreName = genreName;
                            genres.Add(genre);                            
                        }
                    }
                }
            }

            return genres;
        }

        public void add(Genre genre)
        {
            // прописать логику создания нового жанра в случае необходимости
        }
    }
}
