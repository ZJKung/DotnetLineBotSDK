using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Line
{
    public class LineMessageRequest : IRequestMessage
    {
        [JsonPropertyName("replyToken")]
        public string ReplyToken { get; set; }
        [JsonPropertyName("messages")]
        public List<IRequestMessage> Messages { get; set; } = new List<IRequestMessage>();
    }
}
