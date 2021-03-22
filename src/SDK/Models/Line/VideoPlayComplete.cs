using System.Text.Json.Serialization;

namespace DotnetcoreLineBot.Models.Line
{
    public class VideoPlayComplete
    {
        [JsonPropertyName("trackingId")]
        public string TrackingId { get; set; }
    }
}