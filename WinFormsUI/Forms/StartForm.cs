
using MusicCatalog.Core.Entities;
using MusicCatalog.Core.Strategies;
using MusicCatalog.DAL.Repositories;
using System.DirectoryServices;

using MusicCatalog.Core.Interfaces;


namespace MusicCatalog.WinFormsUI.Forms
{
    public partial class StartForm : Form
    {
        private string _searchQuery = "";
        private string _criteria = "All";

        private static ArtistRepository _artistRepository = new ArtistRepository();
        private static ArtistSearchStrategy _artistSearchStrategy = new ArtistSearchStrategy(_artistRepository);

        

        public StartForm()
        {
            InitializeComponent();
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchResult.Items.Clear();



            switch (_criteria)
            {
                case "Artists":
                    List<Artist> artists;
                    artists = _artistSearchStrategy.Search(_searchQuery);
                    foreach (var artist in artists)
                    {
                        SearchResult.Items.Add(artist.Nickname);
                    }

                    break;

                default:
                    MessageBox.Show("Пожалуйста, выберите критерий поиска.");
                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {

            AdministrationForm adminForm = new AdministrationForm(this);

            adminForm.Show();

            this.Hide();
        }

        private void All_CheckedChanged(object sender, EventArgs e)
        {
            _criteria = "All";
        }

        private void Song_CheckedChanged(object sender, EventArgs e)
        {
            _criteria = "Song";
        }

        private void Albums_CheckedChanged(object sender, EventArgs e)
        {
            _criteria = "Albums";
        }

        private void PlayLists_CheckedChanged(object sender, EventArgs e)
        {
            _criteria = "PlayLists";
        }

        private void Artists_CheckedChanged(object sender, EventArgs e)
        {
            _criteria = "Artists";
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            _searchQuery = SearchBox.Text;
        }

        private void SearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
