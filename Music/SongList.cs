using Newtonsoft.Json;
using System.Collections.Generic;

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