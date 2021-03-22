using System.Text.Json.Serialization;

namespace DotnetcoreLineBot.Models.RichMenu
{
    public class RichMenuBounds
    {
        [JsonPropertyName("x")]
        public int XAxis { get; set; }

        [JsonPropertyName("y")]
        public int YAxis { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }
    }
}