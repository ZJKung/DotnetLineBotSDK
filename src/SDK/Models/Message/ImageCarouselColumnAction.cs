using System;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Message
{
    public class ImageCarouselColumnAction
    {
        [JsonPropertyName("thumbnailImageUrl")]
        public string ThumbnailImageUrl { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }
        [JsonPropertyName("defaultAction")]
        public ColumnDefaultaction DefaultAction { get; set; }
        [JsonPropertyName("action")]
        public IAction Action { get; set; }
    }
}
