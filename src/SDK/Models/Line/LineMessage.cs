using System.Text.Json.Serialization;
using DotnetcoreLineBot.Enums;

namespace DotnetcoreLineBot.Models.Line
{
    public class LineMessage
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("type")]
        public LineMessageType Type { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}