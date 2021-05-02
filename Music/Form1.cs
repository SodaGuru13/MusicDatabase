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
                addSong();
            }
            else
            {
                _currentSong = _songList.Songs.First();
            }
            updateUI();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(_songList, Formatting.Indented));
        }

        private void NavAdd_Click(object sender, EventArgs e)
        {
            addSong();
            updateUI();
        }

        private void addSong()
        {
            _currentSong = _songList.AddSong();
        }

        private void navApplyChanges_Click(object sender, EventArgs e)
        {
            updateCurrentSong();
        }

        private void updateUI()
        {
            txtSongTitle.Text = _currentSong.Name;
            txtSongDescription.Text = _currentSong.Description;
            txtArtist.Text = _currentSong.Artist.Name;
            txtAlbum.Text = _currentSong.Album.Name;
            txtGenre.Text = _currentSong.Genre.Name;
        }

        private void updateCurrentSong()
        {
            _currentSong.Name = txtSongTitle.Text;
            _currentSong.Description = txtSongDescription.Text;
            _currentSong.Artist.Name = txtArtist.Text;
            _currentSong.Album.Name = txtAlbum.Text;
            _currentSong.Genre.Name = txtGenre.Text;
        }

        private void navLeft_Click(object sender, EventArgs e)
        {
            var currentIndex = _songList.Songs.IndexOf(_currentSong);
            if(currentIndex > 0)
            {
                _currentSong = _songList.Songs[currentIndex-1];
                updateUI();
            }
        }

        private void navRight_Click(object sender, EventArgs e)
        {
            var currentIndex = _songList.Songs.IndexOf(_currentSong);
            if (currentIndex < _songList.Songs.Count-1)
            {
                _currentSong = _songList.Songs[currentIndex + 1];
                updateUI();
            }
        }

        private void navDelete_Click(object sender, EventArgs e)
        {
            var currentIndex = _songList.Songs.IndexOf(_currentSong);
            _songList.Songs.Remove(_currentSong);
            if (currentIndex < _songList.Songs.Count - 1)
                _currentSong = _songList.Songs[currentIndex];
            else if(currentIndex-1 > -1)
                _currentSong = _songList.Songs[currentIndex-1];
            else
                addSong();


            updateUI();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void navCopySong_Click(object sender, EventArgs e)
        {
            _currentSong = new Song(_currentSong.Name, _currentSong.Description);
            _songList.Songs.Add(_currentSong);
        }
    }

}
