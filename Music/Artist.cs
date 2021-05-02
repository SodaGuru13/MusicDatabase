using Newtonsoft.Json;

namespace Music
{
    public class Artist
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
    }
}
