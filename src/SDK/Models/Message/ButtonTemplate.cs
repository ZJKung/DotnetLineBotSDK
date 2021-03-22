using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Enums;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Message
{
    public class ButtonTemplate : ITemplate
    {
        public ButtonTemplate(string text, List<IAction> actions, string thumbnailImageUrl = null)
        {
            Text = text;
            Actions = actions;
            ThumbnailImageUrl = thumbnailImageUrl;
        }
        [JsonPropertyName("thumbnailImageUrl")]
        public string ThumbnailImageUrl { get; set; }
        [JsonPropertyName("imageAspectRatio")]

        public ImageAspectRatioType ImageAspectRatio { get; set; } = ImageAspectRatioType.rectangle;
        [JsonPropertyName("imageSize")]

        public ImageSizeType ImageSize { get; set; } = ImageSizeType.cover;
        [JsonPropertyName("imageBackgroundColor")]

        public string ImageBackgroundColor { get; set; } = "#FFFFFF";
        [JsonPropertyName("title")]

        public string Title { get; set; }
        [JsonPropertyName("text")]

        public string Text { get; set; }
        [JsonPropertyName("defaultAction")]

        public ColumnDefaultaction DefaultAction { get; set; }
        [JsonPropertyName("actions")]
        public List<IAction> Actions { get; set; }
    }
}
