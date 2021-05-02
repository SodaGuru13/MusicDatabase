using Newtonsoft.Json;

namespace Music
{
    public class Artist : IMegaBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("birthday")]
        public string Birthday { get; set; }
        [JsonProperty("died")]
        public string Deathday { get; set; }

    }
}
