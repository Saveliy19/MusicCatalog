using MusicCatalog.Core.Entities;
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
    internal partial class AboutAlbumForm : Form
    {
        private Form _prevForm;
        public AboutAlbumForm(Form prevForm, Album album)
        {
            InitializeComponent();
            _prevForm = prevForm;
            AlbumNameLabel.Text = "Альбом " + album.Name;
            ArtistNameLabel.Text = "Исполнитель " + album.ArtistName;
            foreach (Song song in album.Songs)
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


    }
}
