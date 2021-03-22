using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DotnetcoreLineBot.Models.RichMenu
{
    public class RichMenuResponse
    {
        [JsonPropertyName("richMenus")]
        public List<RichMenu> RichMenus { get; set; }
    }
}
