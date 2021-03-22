using System;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Enums;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Action
{
    public class MessageAction : IAction
    {
        public MessageAction(string text, string label = "")
        {
            Text = text;
            Label = string.IsNullOrEmpty(label) ? text : label;
        }
        [JsonPropertyName("texts")]
        public string Text { get; set; }
        [JsonPropertyName("type")]
        public ActionType Type => ActionType.message;
        [JsonPropertyName("label")]
        public string Label { get; set; }
    }
}
