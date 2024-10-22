using MusicCatalog.Core.Entities;
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

namespace MusicCatalog.WinFormsUI.Forms
{
    internal partial class AboutPlaylistForm : Form
    {
        private Form _prevForm;
        private PlayList _playlist;

        public AboutPlaylistForm(Form prevForm, PlayList playlist)
        {
            InitializeComponent();
            _prevForm = prevForm;
            _playlist = playlist;
            label3.Text = _playlist.Name;
            foreach (var song in playlist.Songs)
            {
                TrackListBox.Items.Add($"{song.Name}| исп.{song.ArtistName}| альб.{song.AlbumName}");
                TrackListBox.Items.Add($"{Convert.ToInt32(song.Duration) / 60}m {Convert.ToInt32(song.Duration) % 60}s| {song.Genre}");
                TrackListBox.Items.Add("------------------------------------------------------------------------------------------");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _prevForm.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TrackListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
