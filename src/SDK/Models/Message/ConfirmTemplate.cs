using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Interfaces;
using DotnetcoreLineBot.Models.Action;

namespace DotnetcoreLineBot.Models.Message
{
    public class ConfirmTemplate : ITemplate
    {
        public ConfirmTemplate(string text = "您確定嗎?")
        {
            Text = text;
            Actions = new List<IAction>()
            {
                new MessageAction("Yes", "是"),
                new MessageAction("No", "否")
            };
        }
        [JsonPropertyName("type")]
        public string Type => "confirm";
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("actions")]
        public List<IAction> Actions { get; set; }
    }
}
