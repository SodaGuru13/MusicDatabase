using Newtonsoft.Json;

namespace Music
{
    public class SongBase
    {
        [JsonProperty("artist")]
        public Artist Artist { get; set; }
        [JsonProperty("album")]
        public Album Album { get; set; }
        [JsonProperty("genre")]
        public Genre Genre { get; set; }
        public SongBase()
        {
            Artist = new Artist();
            Album = new Album();
            Genre = new Genre();
        }
    }
}