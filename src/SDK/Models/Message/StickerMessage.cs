using System;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Enums;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Message
{
    public class StickerMessage : IMessage
    {
        [JsonPropertyName("type")]
        public LineMessageType Type => LineMessageType.sticker;
        [JsonPropertyName("packageId")]
        public string PackageId { get; set; }
        [JsonPropertyName("stickerId")]
        public string StickerId { get; set; }
    }
}
