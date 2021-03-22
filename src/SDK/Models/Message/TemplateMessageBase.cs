using System;
using DotnetcoreLineBot.Interfaces;
using DotnetcoreLineBot.Enums;
using System.Text.Json.Serialization;

namespace DotnetcoreLineBot.Models.Message
{
    public class TemplateMessageBase : IMessage
    {
        [JsonPropertyName("type")]
        public LineMessageType Type => LineMessageType.template;
        [JsonPropertyName("altText")]
        public string AltText => "";
        [JsonPropertyName("template")]
        public ITemplate Template { get; set; }
    }
}
