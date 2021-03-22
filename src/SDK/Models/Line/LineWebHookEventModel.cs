
using System.Collections.Generic;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Models.Line;
namespace DotnetcoreLineBot.Models.Line
{
    public partial class WebHookEvent
    {
        [JsonPropertyName("destination")]
        public string Destination { get; set; }

        [JsonPropertyName("events")]
        public List<LineEvent> Events { get; set; }
    }
}

