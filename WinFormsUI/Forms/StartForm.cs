
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
        private string _criteria = "Genre";

        private static ArtistRepository _artistRepository = new ArtistRepository();
        private static AlbumRepository _albumRepository = new AlbumRepository();
        private static PlayListRepository _playlistRepository = new PlayListRepository();
        private static SongRepository _songRepository = new SongRepository();


        private static ArtistSearchStrategy _artistSearchStrategy = new ArtistSearchStrategy(_artistRepository);
        private static AlbumSearchStrategy _albumSearchStrategy = new AlbumSearchStrategy(_albumRepository);
        private static PlayListSearchStrategy _playListSearchStrategy = new PlayListSearchStrategy(_playlistRepository);

        private static SongNameSearchStrategy _songNameSearchStrategy = new SongNameSearchStrategy(_songRepository);
        private static SongGenreSearchStrategy _songGenreSearchStrategy = new SongGenreSearchStrategy(_songRepository);

        private SongSearchContext _songSearchContext = new SongSearchContext(_songGenreSearchStrategy);


        public StartForm()
        {
            InitializeComponent();
        }

        private void ShowArtists()
        {
            SearchResult.Items.Clear();
            List<Artist> artists;
            artists = _artistSearchStrategy.Search(_searchQuery);
            foreach (var artist in artists)
            {
                SearchResult.Items.Add(artist.Nickname);
            }
        }

        private void ShowAlbums()
        {
            SearchResult.Items.Clear();
            List<Album> albums;
            albums = _albumSearchStrategy.Search(_searchQuery);
            foreach (var album in albums)
            {
                SearchResult.Items.Add($"{album.Name} - {album.ArtistName}");
            }
        }

        private void ShowPlayLists()
        {
            SearchResult.Items.Clear();
            List<PlayList> playLists;
            playLists = _playListSearchStrategy.Search(_searchQuery);
            foreach (var playlist in playLists)
            {
                SearchResult.Items.Add($"{playlist.Name} - {playlist.Id}");
            }
        }

        private void ShowSongs()
        {
            SearchResult.Items.Clear();
            List<Song> songs;
            songs = _songSearchContext.Search(_searchQuery);
            foreach (var song in songs)
            {
                SearchResult.Items.Add(song.Name);
            }
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
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
            _criteria = "Genre";
            _songSearchContext.SetStrategy(_songGenreSearchStrategy);
            ShowSongs();
        }

        private void Song_CheckedChanged(object sender, EventArgs e)
        {
            _criteria = "Song";
            _songSearchContext.SetStrategy(_songNameSearchStrategy);
            ShowSongs();
        }

        private void Albums_CheckedChanged(object sender, EventArgs e)
        {
            _criteria = "Albums";
            ShowAlbums();
            
        }

        private void PlayLists_CheckedChanged(object sender, EventArgs e)
        {
            _criteria = "PlayLists";
            ShowPlayLists();
        }

        private void Artists_CheckedChanged(object sender, EventArgs e)
        {
            _criteria = "Artists";
            ShowArtists();

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            _searchQuery = SearchBox.Text;
            
            switch (_criteria)
            {
                case "Artists":
                    ShowArtists();
                    break;

                case "Albums":
                    ShowAlbums();
                    break;

                case "PlayLists":
                    ShowPlayLists();
                    break;

                case "Song" or "Genre":
                    ShowSongs();
                    break;

                default:
                    MessageBox.Show("����������, �������� �������� ������.");
                    break;
            }
        }

        private void SearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
