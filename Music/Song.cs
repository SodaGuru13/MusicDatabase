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
    public class Song
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("duration")]
        public string Duration { get; set; }
        [JsonProperty("creation")]
        public DateTime Creation { get; set; }
        // working on containers in side of containers we could add arrays of items (lists) but not necessary now.
        [JsonProperty("artist")]
        public Artist Artist { get; set; }
        [JsonProperty("album")]
        public Album Album { get; set; }
        [JsonProperty("genre")]
        public Genre Genre { get; set; }
        public Song()
        {
            Artist = new Artist();
            Album = new Album();
            Genre = new Genre();
        }
    }
}
