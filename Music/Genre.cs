using Newtonsoft.Json;

namespace Music
{
    public class Genre
    {
        [JsonProperty("name")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
