using Newtonsoft.Json;

namespace Music
{
    public class Genre : IMegaBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("instrument")]
        public string Instrument { get; set; }

    }
}
