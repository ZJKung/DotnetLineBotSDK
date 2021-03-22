using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Message
{
    public class ImageCarouselTemplate : ITemplate
    {
        [JsonPropertyName("type")]
        public string Type => "image_carousel";
        [JsonPropertyName("columns")]

        public List<ImageCarouselColumnAction> Columns { get; set; }
    }
}
