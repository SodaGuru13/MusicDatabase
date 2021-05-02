using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Music
{
    public partial class Form1 : Form
    {
        private readonly string path = AppDomain.CurrentDomain.BaseDirectory + "Songs.json";
        SongList _songList;
        Song _currentSong;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new();
            ToolTip1.SetToolTip(this.navAdd, "Add Song");
            ToolTip ToolTip2 = new();
            ToolTip2.SetToolTip(this.navLeft, "Navigate Left/Up");
            ToolTip ToolTip3 = new();
            ToolTip3.SetToolTip(this.navRight, "Navigate Right/Down");
            ToolTip ToolTip4 = new();
            ToolTip4.SetToolTip(this.navDelete, "Delete Song");

            // load songs
            try
            {
                string file = File.ReadAllText(path);
                _songList = (SongList)JsonConvert.DeserializeObject(file, typeof(SongList));
            }
            catch (FileNotFoundException)
            {
                _songList = new SongList();
            }

            if (_songList.Songs.Count == 0)
            {
                AddSong();
            }
            else
            {
                _currentSong = _songList.Songs.First();
            }
            UpdateUI();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(_songList, Formatting.Indented));
        }

        private void NavAdd_Click(object sender, EventArgs e)
        {
            AddSong();
            UpdateUI();
        }

        private void AddSong()
        {
            _currentSong = _songList.AddSong();
        }

        private void NavApplyChanges_Click(object sender, EventArgs e)
        {
            UpdateCurrentSong();
        }

        private void UpdateUI()
        {
            txtSongTitle.Text = _currentSong.Name;
            txtSongDescription.Text = _currentSong.Description;
            txtSongDuration.Text = _currentSong.Duration;
            txtSongCreation.Text = _currentSong.Creation;
            txtArtistName.Text = _currentSong.Artist.Name;
            txtArtistDescription.Text = _currentSong.Artist.Description;
            txtArtistBirthday.Text = _currentSong.Artist.Birthday;
            txtArtistDeath.Text = _currentSong.Artist.Deathday;
            txtAlbumName.Text = _currentSong.Album.Name;
            txtAlbumDescription.Text = _currentSong.Album.Description;
            txtAlbumDuration.Text = _currentSong.Album.Duration;
            txtAlbumCreation.Text = _currentSong.Album.Creation;
            txtGenreName.Text = _currentSong.Genre.Name;
            txtGenreDescription.Text = _currentSong.Genre.Description;
            txtGenreInstrument.Text = _currentSong.Genre.Instrument;
            txtGenreCreation.Text = _currentSong.Genre.Creation;
        }

        private void UpdateCurrentSong()
        {
            _currentSong.Name = txtSongTitle.Text;
            _currentSong.Description = txtSongDescription.Text;
            _currentSong.Duration = txtSongDuration.Text;
            _currentSong.Creation = txtSongCreation.Text;
            _currentSong.Artist.Name = txtArtistName.Text;
            _currentSong.Artist.Description = txtArtistDescription.Text;
            _currentSong.Artist.Birthday = txtArtistBirthday.Text;
            _currentSong.Artist.Deathday = txtArtistDeath.Text;
            _currentSong.Album.Name = txtAlbumName.Text;
            _currentSong.Album.Description = txtAlbumDescription.Text;
            _currentSong.Album.Duration = txtAlbumDuration.Text;
            _currentSong.Album.Creation = txtAlbumCreation.Text;
            _currentSong.Genre.Name = txtGenreName.Text;
            _currentSong.Genre.Description = txtGenreDescription.Text;
            _currentSong.Genre.Instrument = txtGenreInstrument.Text;
            _currentSong.Genre.Creation = txtGenreCreation.Text;
        }

        private void NavLeft_Click(object sender, EventArgs e)
        {
            var currentIndex = _songList.Songs.IndexOf(_currentSong);
            if(currentIndex > 0)
            {
                _currentSong = _songList.Songs[currentIndex-1];
                UpdateUI();
            }
        }

        private void NavRight_Click(object sender, EventArgs e)
        {
            var currentIndex = _songList.Songs.IndexOf(_currentSong);
            if (currentIndex < _songList.Songs.Count-1)
            {
                _currentSong = _songList.Songs[currentIndex + 1];
                UpdateUI();
            }
        }

        private void NavDelete_Click(object sender, EventArgs e)
        {
            var currentIndex = _songList.Songs.IndexOf(_currentSong);
            _songList.Songs.Remove(_currentSong);
            if (currentIndex < _songList.Songs.Count - 1)
                _currentSong = _songList.Songs[currentIndex];
            else if(currentIndex-1 > -1)
                _currentSong = _songList.Songs[currentIndex-1];
            else
                AddSong();


            UpdateUI();
        }
        private void NavCopySong_Click(object sender, EventArgs e)
        {
            _currentSong = new Song(_currentSong.Name, _currentSong.Description);
            _songList.Songs.Add(_currentSong);
        }

        private void btnEstimateAlbumDuration_Click(object sender, EventArgs e)
        {
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            UpdateCurrentSong();
            var listofDurations = _songList.Songs.Where(p => p.Album.Name == _currentSong.Album.Name).Select(k => k.Duration);
            foreach (var item in listofDurations)
            {
                string[] splitter = item.Split(":");
                minutes += int.Parse(splitter[0]);
                seconds += int.Parse(splitter[1]);
                if (seconds > 60)
                {
                    minutes += seconds / 60;
                    seconds = seconds % 60;
                }
                if(minutes > 60)
                {
                    hours += minutes / 60;
                    minutes = minutes % 60;
                }
            }
            txtAlbumDuration.Text = $"{hours.ToString("00")}:{minutes.ToString("00")}:{seconds.ToString("00")}";
        }

        private void txtAlbumName_TextChanged(object sender, EventArgs e)
        {
            btnEstimateAlbumDuration.Enabled = !string.IsNullOrWhiteSpace(txtAlbumName.Text);
        }
    }

}
