using Newtonsoft.Json;
using System;

namespace Music
{
    public class Album : IMegaBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("duration")]
        public string Duration { get; set; }
        [JsonProperty("creation")]
        public string Creation { get; set; }
    }
}
