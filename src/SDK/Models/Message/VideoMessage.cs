using System;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Enums;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Message
{
    public class VideoMessage : IMessage
    {
        [JsonPropertyName("type")]
        public LineMessageType Type => LineMessageType.video;
        [JsonPropertyName("originalContentUrl")]

        public string OriginalContentUrl { get; set; }
        [JsonPropertyName("previewImageUrl")]

        public string PreviewImageUrl { get; set; }
        [JsonPropertyName("trackingId")]

        public string TrackingId { get; set; }
    }
}
