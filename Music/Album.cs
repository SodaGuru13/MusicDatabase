using Newtonsoft.Json;
using System;

namespace Music
{
    public class Album
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("duration")]
        public string Duration { get; set; }
        [JsonProperty("creation")]
        public DateTime Creation { get; set; }
    }
}
