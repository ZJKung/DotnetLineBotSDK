using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Message
{
    public class QuickReply
    {
        public List<QuickReplyItem> Items = new List<QuickReplyItem>();
    }
    public class QuickReplyItem
    {
        [JsonPropertyName("type")]
        public string Type => "action";
        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }
        [JsonPropertyName("action")]
        public IAction Action { get; set; }
    }
}
