
using MusicCatalog.Core.Entities;
using MusicCatalog.DAL.Repositories;
using System.DirectoryServices;

using MusicCatalog.Core.Interfaces;
using MusicCatalog.Core.Strategies.Songs;
using MusicCatalog.Core.Strategies.Artists;
using MusicCatalog.Core.Strategies.Playlists;
using MusicCatalog.Core.Strategies.Albums;


namespace MusicCatalog.WinFormsUI.Forms
{
    public partial class StartForm : Form
    {
        private string _searchQuery = "";
        private string _criteria = "Genre";

        List<PlayList> _playLists;
        List<Album> _albums;
        List<Artist> _artists;

        private SongSearchContext _songSearchContext = new SongSearchContext(new SongGenreSearchStrategy(SongRepository.Instance));
        private ArtistSearchContext _artistSearchContext = new ArtistSearchContext(new ArtistSearchStrategy(ArtistRepository.Instance));
        private PlaylistSearchContext _playlistSearchContext = new PlaylistSearchContext(new PlayListSearchStrategy(PlayListRepository.Instance));
        private AlbumSearchContext _albumSearchContext = new AlbumSearchContext(new AlbumNameSearchStrategy(AlbumRepository.Instance));

        public StartForm()
        {
            InitializeComponent();
        }

        private void ShowArtists()
        {
            SearchResult.Items.Clear();
            _artists = _artistSearchContext.Search(_searchQuery);
            foreach (var artist in _artists)
            {
                SearchResult.Items.Add(artist.Nickname);
            }
        }

        private void ShowAlbums()
        {
            SearchResult.Items.Clear();
            _albums = _albumSearchContext.Search(_searchQuery);
            foreach (var album in _albums)
            {
                SearchResult.Items.Add($"{album.Name} - {album.ArtistName}");
            }
        }

        private void ShowPlayLists()
        {
            SearchResult.Items.Clear();
            _playLists = _playlistSearchContext.Search(_searchQuery);
            foreach (var playlist in _playLists)
            {
                SearchResult.Items.Add($"{playlist.Name} - {playlist.Id}");
            }
        }

        private void ShowSongs()
        {
            SearchResult.Items.Clear();
            List<Song> songs = _songSearchContext.Search(_searchQuery);
            foreach (var song in songs)
            {
                SearchResult.Items.Add($"{song.Name}| исп.{song.ArtistName}| альб.{song.AlbumName}");
                SearchResult.Items.Add($"{Convert.ToInt32(song.Duration) / 60}m {Convert.ToInt32(song.Duration) % 60}| {song.Genre}");
                SearchResult.Items.Add("------------------------------------------------------------------------------------------");
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
            _songSearchContext.SetStrategy(new SongGenreSearchStrategy(SongRepository.Instance));
            ShowSongs();
        }

        private void Song_CheckedChanged(object sender, EventArgs e)
        {
            _criteria = "Song";
            _songSearchContext.SetStrategy(new SongNameSearchStrategy(SongRepository.Instance));
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
                    MessageBox.Show("Пожалуйста, выберите критерий поиска.");
                    break;
            }
        }

        private void SearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchResult.SelectedIndex >= 0)
            {
                switch (_criteria)
                {
                    case "Artists":
                        AboutArtistForm artistForm = new AboutArtistForm(this, _artists[SearchResult.SelectedIndex]);
                        artistForm.Show();
                        this.Hide();
                        break;

                    case "Albums":
                        AboutAlbumForm albumForm = new AboutAlbumForm(this, _albums[SearchResult.SelectedIndex]);
                        albumForm.Show();
                        this.Hide();
                        break;

                    case "PlayLists":
                        AboutPlaylistForm playlistForm = new AboutPlaylistForm(this, _playLists[SearchResult.SelectedIndex]);
                        playlistForm.Show();
                        this.Hide();
                        break;

                    case "Song":
                    case "Genre":
                        break;

                    default:
                        MessageBox.Show("Пожалуйста, выберите критерий поиска.");
                        break;
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
