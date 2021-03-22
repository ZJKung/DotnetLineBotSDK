using System;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Enums;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Message
{
    public class AudioMessage : IMessage
    {
        [JsonPropertyName("text")]
        public LineMessageType Type => LineMessageType.audio;
        [JsonPropertyName("originalContentUrl")]
        public string OriginalContentUrl { get; set; }
        [JsonPropertyName("duration")]
        public int Duration { get; set; } = 60000;
    }
}
