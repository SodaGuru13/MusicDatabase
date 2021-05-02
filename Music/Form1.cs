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
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.navAdd, "Add Song");
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.navLeft, "Navigate Left/Up");
            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.navRight, "Navigate Right/Down");
            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip4.SetToolTip(this.navDelete, "Delete Song");

            // load songs
            try
            {
                string file = File.ReadAllText(path);
                _songList = (SongList)Newtonsoft.Json.JsonConvert.DeserializeObject(file, typeof(SongList));
            }
            catch (FileNotFoundException)
            {
                _songList = new SongList();
            }

            if (_songList.Songs.Count() == 0)
            {
                addSong();
            }
            else
            {
                _currentSong = _songList.Songs.First();
            }
            updateUI();
            // data bindings   Auto applys ui changes to objects 
            //https://stackoverflow.com/questions/1616003/data-binding-for-textbox
            //this.txtSongTitle.DataBindings.Add("Text",
            //        _currentSong,
            //        "Title",
            //        false,
            //        DataSourceUpdateMode.OnPropertyChanged);
            //this.txtArtist.DataBindings.Add("Text",
            //        _currentSong.Artist,
            //        "Name",
            //        false,
            //        DataSourceUpdateMode.OnPropertyChanged);

            //this.txtAlbum.DataBindings.Add("Text",
            //        _currentSong.Album,
            //        "Title",
            //        false,
            //        DataSourceUpdateMode.OnPropertyChanged);

            //this.txtGenre.DataBindings.Add("Text",
            //        _currentSong.Genre,
            //        "Title",
            //        false,
            //        DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save
            File.WriteAllText(path, JsonConvert.SerializeObject(_songList, Formatting.Indented));
        }

        private void navAdd_Click(object sender, EventArgs e)
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
            txtSongTitle.Text = _currentSong.Title;
            txtDuration.Text = _currentSong.Duration;
            txtArtist.Text = _currentSong.Artist.Name;
            txtAlbum.Text = _currentSong.Album.Title;
            txtGenre.Text = _currentSong.Genre.Title;
        }

        private void updateCurrentSong()
        {
            _currentSong.Title = txtSongTitle.Text;
            _currentSong.Duration = txtDuration.Text;
            _currentSong.Artist.Name = txtArtist.Text;
            _currentSong.Album.Title = txtAlbum.Text;
            _currentSong.Genre.Title = txtGenre.Text;
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
    }

}
