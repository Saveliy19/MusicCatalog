using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Strategies.Albums;
using MusicCatalog.DAL.Repositories;
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
    internal partial class AboutArtistForm : Form
    {
        private Form _prevForm;
        private List<Album> _albums;

        private AlbumSearchContext _albumSearchContext = new AlbumSearchContext(new AlbumArtistSearchStrategy(AlbumRepository.Instance));
        public AboutArtistForm(Form prevForm, Artist artist)
        {
            InitializeComponent();
            _prevForm = prevForm;
            ArtistNameLabel.Text = artist.Nickname;
            _albums = _albumSearchContext.Search(artist.Nickname);
            foreach (var album in _albums)
            {
                ArtistAlbums.Items.Add(album.Name);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _prevForm.Show();
            this.Close();
        }

        private void ArtistAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 <= ArtistAlbums.SelectedIndex)
            {
                AboutAlbumForm albumForm = new AboutAlbumForm(this, _albums[ArtistAlbums.SelectedIndex]);
                albumForm.Show();
                this.Hide();
            }
            
        }
    }
}
