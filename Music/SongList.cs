using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public class SongList
    {
        // Learned how to use us serialization attributes for C# and the json deserializer and serializer
        [JsonProperty("songs")]
        public List<Song> Songs { get; set; }

        public SongList()
        {
            Songs = new List<Song>();
        }

        public Song AddSong()
        {
            var song = new Song();
            Songs.Add(song);
            return song;
        }
    }
}