using System;
using System.Text.Json.Serialization;

namespace DotnetcoreLineBot.Models.RichMenu
{
    public class RichMenu
    {
        [JsonPropertyName("richMenuId")]
        public string RichMenuId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("size")]
        public RichMenuSize Size { get; set; }

        [JsonPropertyName("charbarText")]
        public string ChatBarText { get; set; }

        [JsonPropertyName("selected")]
        public bool Selected { get; set; }

        [JsonPropertyName("areas")]
        public RichMenuArea[] Areas { get; set; }
    }
}
