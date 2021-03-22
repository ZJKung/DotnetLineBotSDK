using System;
using System.Text.Json.Serialization;

namespace DotnetcoreLineBot.Models.Message
{
    public class ColumnDefaultaction
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("label")]
        public string Label { get; set; }
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
