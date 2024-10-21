using MusicCatalog.Core.Builders;
using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Strategies;
using MusicCatalog.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicCatalog.WinFormsUI.Forms
{
    public partial class AlbumCreatingForm : Form
    {
        private AdministrationForm _administrationForm;
        private List<Song> _songList = new List<Song>();

        private List<Artist> _artists = new List<Artist>();

        private List<Genre> _genres = new List<Genre>();

        private static ArtistRepository _artistRepository = new ArtistRepository();
        private ArtistSearchStrategy _artistSearchStrategy = new ArtistSearchStrategy(_artistRepository);

        private AlbumRepository _albumRepository = new AlbumRepository();
        private GenreRepository _genreRepository = new GenreRepository();
        public AlbumCreatingForm(AdministrationForm administrationForm)
        {
            InitializeComponent();
            _administrationForm = administrationForm;
            _genres = _genreRepository.Search("");
            foreach (Genre genre in _genres)
            {
                GenreBox.Items.Add(genre.GenreName);
            }
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            _administrationForm.Show();
            this.Close();
        }

        private void Minutes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Seconds_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SongName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlbumName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSongButton_Click(object sender, EventArgs e)
        {

            if (Minutes.Value == 0 && Seconds.Value == 0)
            {
                MessageBox.Show("Трек не может иметь нулевую длительность!");
                return;
            }

            else if (SongName.Text == "")
            {
                MessageBox.Show("Вы не ввели название трека!");
                return;
            }

            else if (GenreBox.SelectedItem is null)
            {
                MessageBox.Show("Вы не указали жанр трека!");
                return;
            }

            var songBuilder = new SongBuilder();
            var song = songBuilder.SetName(SongName.Text).SetGenre(GenreBox.SelectedItem.ToString()).SetDuration((int)(Minutes.Value * 60 + Seconds.Value)).Build();

            if (!SongListBox.Items.Contains($"{song.Name}, {Minutes.Value}min {Seconds.Value}sec"))
            {

                SongListBox.Items.Add($"{song.Name}, {Minutes.Value}min {Seconds.Value}sec");
                _songList.Add(song);
                Minutes.Value = 0;
                Seconds.Value = 0;
                SongName.Text = "";
            }
            else MessageBox.Show("Трек уже в списке!");
        }

        private void SongListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ArtistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ArtistBox_TextChanged(object sender, EventArgs e)
        {

            // Сохраняем текущее положение курсора
            int selectionStart = ArtistBox.SelectionStart;

            _artists = _artistSearchStrategy.Search(ArtistBox.Text);
            ArtistBox.Items.Clear();

            foreach (var artist in _artists)
            {
                ArtistBox.Items.Add(artist.Nickname);
            }

            ArtistBox.DroppedDown = true;
            ArtistBox.SelectionStart = selectionStart;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (_songList.Count == 0)
            {
                MessageBox.Show("Вы не добавили ни одного трека!");
                return;
            }

            else if (ArtistBox.SelectedItem is null)
            {
                MessageBox.Show("Вы не указали артиста!");
                return;
            }
            else if (AlbumName.Text == "")
            {
                MessageBox.Show("Вы не указали название альбома!");
                return;
            }
            var albumBuilder = new AlbumBuilder();
            var album = albumBuilder.SetArtistName(ArtistBox.SelectedItem.ToString()).SetName(AlbumName.Text).AddSongs(_songList).Build();
            _albumRepository.add(album);
            AlbumName.Text = "";
            SongListBox.Items.Clear();
            ArtistBox.SelectedItem = null;
            MessageBox.Show($"Альбом {AlbumName.Text} создан!");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void GenreBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
