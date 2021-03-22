using System;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Enums;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Message
{
    public class FlexMessage : IMessage
    {
        [JsonPropertyName("type")]
        public LineMessageType Type => LineMessageType.flex;
        [JsonPropertyName("altText")]
        public string AltText => "Flex Message";
        [JsonPropertyName("contents")]
        public string Contents { get; set; }
    }
}
