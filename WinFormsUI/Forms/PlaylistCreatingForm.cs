using MusicCatalog.Core.Entities;
using MusicCatalog.DAL.Repositories;
using MusicCatalog.Core.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicCatalog.Core.Strategies.Songs;

namespace MusicCatalog.WinFormsUI.Forms
{
    public partial class PlaylistCreatingForm : Form
    {
        private string _searchQuery;
        private AdministrationForm _administrationForm;

        private SongSearchContext _songSearchContext = new SongSearchContext(new SongNameSearchStrategy(SongRepository.Instance));

        

        private List<Song> _songList = new List<Song>();
        public PlaylistCreatingForm(AdministrationForm administrationForm)
        {
            InitializeComponent();
            _administrationForm = administrationForm;
        }

        private void ShowSongs()
        {
            SearchResult.Items.Clear();
            List<Song> songs = _songSearchContext.Search(_searchQuery);

            SearchResult.DisplayMember = "Name"; 
            SearchResult.ValueMember = "Id";     

            foreach (var song in songs)
            {
                SearchResult.Items.Add(song); 
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _administrationForm.Show();
            this.Close();
        }

        private void SearchSongBox_TextChanged(object sender, EventArgs e)
        {
            _searchQuery = SearchSongBox.Text;
            ShowSongs();
        }

        private void PlaylistName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchResult.SelectedItem != null)
            {
                // Получаем выбранный объект Song
                Song selectedSong = (Song)SearchResult.SelectedItem;

                // Получаем ID выбранной песни
                int songId = selectedSong.Id;

                PlayListSongs.DisplayMember = "Name";
                PlayListSongs.ValueMember = "Id";


                if (!_songList.Contains(selectedSong))
                {
                    PlayListSongs.Items.Add(selectedSong);
                    _songList.Add(selectedSong);
                }


            }
        }

        private void PlayListSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlayListSongs.SelectedItem != null)
            {
                Song selectedSong = (Song)PlayListSongs.SelectedItem;

                // Получаем ID выбранной песни
                int songId = selectedSong.Id;

                PlayListSongs.Items.Remove(selectedSong);

                _songList.Remove(selectedSong);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (_songList.Count > 0 && PlaylistName.Text != "")
            {
                var playlist = new PlayListBuilder().SetName(PlaylistName.Text).AddSongs(_songList).Build();
                var playlistRepository = PlayListRepository.Instance;
                playlistRepository.Add(playlist);
                PlayListSongs.Items.Clear();
                _songList.Clear();
                MessageBox.Show($"Плейлист {PlaylistName.Text} успешно создан");
                PlaylistName.Text = "";
                
                
            }
            else if (_songList.Count == 0) MessageBox.Show("Вы не добавили ни одной песни!");
            else if (PlaylistName.Text == "") MessageBox.Show("Введите название альбома!");
        }
    }
}
