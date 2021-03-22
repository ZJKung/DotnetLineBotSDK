using System.Text.Json.Serialization;

namespace DotnetcoreLineBot.Models.RichMenu
{
    public class RichMenuAction
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}