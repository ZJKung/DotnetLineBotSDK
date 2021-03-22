using System.Text.Json.Serialization;

namespace DotnetcoreLineBot.Models.RichMenu
{
    public class RichMenuArea
    {
        [JsonPropertyName("bounds")]
        public RichMenuBounds Bounds { get; set; }

        [JsonPropertyName("action")]
        public RichMenuAction Action { get; set; }
    }
}