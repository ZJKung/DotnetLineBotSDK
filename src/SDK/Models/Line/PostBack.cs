using System.Text.Json.Serialization;

namespace DotnetcoreLineBot.Models.Line
{
    public class PostBack
    {
        [JsonPropertyName("data")]
        public string Data { get; set; }
        [JsonPropertyName("params")]
        public PostBackParams PostBackParams { get; set; }
    }
}