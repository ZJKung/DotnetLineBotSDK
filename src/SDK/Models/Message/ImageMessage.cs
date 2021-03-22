using System;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Enums;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Message
{
    public class ImageMessage : IMessage
    {
        [JsonPropertyName("type")]
        public LineMessageType Type => LineMessageType.image;
        [JsonPropertyName("originalContentUrl")]

        public string OriginalContentUrl { get; set; }
        [JsonPropertyName("previewImageUrl")]

        public string PreviewImageUrl { get; set; }
    }
}
