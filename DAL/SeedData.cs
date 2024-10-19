using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.DAL
{
    internal class SeedData
    {
        public static void Seed(SQLiteConnection connection)
        {
            
            var command = connection.CreateCommand();
            
            
            command.CommandText = @"
                INSERT INTO GENRE (GENRE_NAME) VALUES ('Rock'), ('Pop'), ('Rap'), ('Phonk');
            ";
            command.ExecuteNonQuery();

            
            command.CommandText = @"
                INSERT INTO ARTIST (NICKNAME) VALUES ('Ivan Smile'), ('Instasamka'), ('Victor Tsoy'), ('Lastfragment');
            ";
            command.ExecuteNonQuery();

            
            command.CommandText = @"
                INSERT INTO ALBUM (ALBUM_NAME, ARTIST_NICKNAME, RELEASE_DATE) VALUES 
                ('HardBassAlbum', 'Ivan Smile', '2024-01-01'),
                ('Popstar', 'Instasamka', '2023-05-07'),
                ('Legend', 'Viktor Tsoy', '1988-08-17'),
                ('Lonely void', 'Lastfragment', '2023-12-12');
            ";
            command.ExecuteNonQuery();

            // Добавляем песни
            command.CommandText = @"
                INSERT INTO SONG (SONG_NAME, DURATION_SECONDS, ALBUM_ID, GENRE_NAME) VALUES 
                ('HardBass', 259, 1, 'Rap'),
                ('HardBass2', 182, 1, 'Rap'),
                ('HarsBass3', 145, 1, 'Pop'),

                ('Mommy', 130, 2, 'Pop'),
                ('Popstar', 565, 2, 'Pop'),
                ('Pumpim Neft', 585, 2, 'Pop'),

                ('Posledniy Geroy', 130, 3, 'Rock'),
                ('Kukushka', 565, 3, 'Rock'),
                ('Gruppa Krovi', 585, 3, 'Rock'),

                ('Lonely Void (slowed)', 1440, 4, 'Phonk');
            ";
            command.ExecuteNonQuery();
        }
    }
}
