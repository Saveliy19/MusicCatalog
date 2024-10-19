using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SQLite;

namespace MusicCatalog.DAL
{
    public static class DatabaseInitializer
    {
        private const string DatabaseFile = "MusicCatalog.db";

        public static void Initialize()
        {


            if (!File.Exists(DatabaseFile))
            {
                CreateDB();
                using (var connection = new SQLiteConnection($"Data Source={DatabaseFile}; Version=3;"))
                {
                    connection.Open();
                    SeedData.Seed(connection); // Вызов метода добавления начальных данных
                }
            }
        }

        private static void CreateDB()
        {
            using (var connection = new SQLiteConnection($"Data Source={DatabaseFile}; Version=3;"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS ARTIST (
                    NICKNAME VARCHAR(50) PRIMARY KEY,
                    REGISTRATION_DATE DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
                );

                CREATE TABLE IF NOT EXISTS GENRE (
                    GENRE_NAME VARCHAR(50) PRIMARY KEY
                );   

                CREATE TABLE IF NOT EXISTS ALBUM (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ALBUM_NAME VARCHAR(50) NOT NULL,
                    RELEASE_DATE DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                    ARTIST_NICKNAME VARCHAR(50) NOT NULL,
                    FOREIGN KEY (ARTIST_NICKNAME) REFERENCES ARTIST(NICKNAME) ON DELETE CASCADE
                );

                CREATE TABLE IF NOT EXISTS SONG (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SONG_NAME VARCHAR(50) NOT NULL,
                    DURATION_SECONDS INTEGER NOT NULL,
                    ALBUM_ID INTEGER NOT NULL,
                    GENRE_NAME VARCHAR(50) NOT NULL,
                    FOREIGN KEY (ALBUM_ID) REFERENCES ALBUM(ID) ON DELETE CASCADE,
                    FOREIGN KEY (GENRE_NAME) REFERENCES GENRE(GENRE_NAME)
                );

                CREATE TABLE IF NOT EXISTS PLAYLIST (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    PLAYLIST_NAME VARCHAR(50) NOT NULL
                );

                CREATE TABLE IF NOT EXISTS PLAYLIST_SONGS (
                    SONG_ID INTEGER NOT NULL,
                    PLAYLIST_ID INTEGER NOT NULL,
                    PRIMARY KEY (SONG_ID, PLAYLIST_ID),
                    FOREIGN KEY (SONG_ID) REFERENCES SONG(ID) ON DELETE CASCADE,
                    FOREIGN KEY (PLAYLIST_ID) REFERENCES PLAYLIST(ID) ON DELETE CASCADE
                );
                ";

                command.ExecuteNonQuery();
            }
        }
    }
}
