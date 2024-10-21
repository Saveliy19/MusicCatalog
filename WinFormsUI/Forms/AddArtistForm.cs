using MusicCatalog.Core.Builders;
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
    public partial class AddArtistForm : Form
    {
        private string _artistName;
        private AdministrationForm _administrationForm;
        private ArtistRepository _artistRepository = new ArtistRepository();
        public AddArtistForm(AdministrationForm adminForm)
        {
            InitializeComponent();
            _administrationForm = adminForm;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _artistName = textBox1.Text;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var artistBuilder = new ArtistBuilder();
            var artist = artistBuilder.SetNickname(textBox1.Text).Build();
            textBox1.Text = "";
            var existing_artist = _artistRepository.Search(_artistName);
            foreach (var item in existing_artist) 
            {
                if (item.Nickname == artist.Nickname) 
                { 
                    MessageBox.Show("Музыкант с таким именем уже существует!");
                    return;
                }
            }
            _artistRepository.add(artist);
            MessageBox.Show("Музыкант успешно создан!");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _administrationForm.Show();
            this.Close();
        }
    }
}
