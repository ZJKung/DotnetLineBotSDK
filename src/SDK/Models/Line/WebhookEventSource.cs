using System.Text.Json.Serialization;

namespace DotnetcoreLineBot.Models.Line
{
    public class WebhookEventSource
    {
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}