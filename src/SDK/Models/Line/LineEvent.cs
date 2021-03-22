using System;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Enums;

namespace DotnetcoreLineBot.Models.Line
{
    public class LineEvent
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("type")]
        public WebhookEventType Type { get; set; }
        [JsonPropertyName("replyToken")]
        public string ReplyToken { get; set; }
        [JsonPropertyName("source")]
        public WebhookEventSource Source { get; set; }
        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }
        [JsonPropertyName("mode")]
        public string Mode { get; set; }
        [JsonPropertyName("message")]
        public LineMessage Message { get; set; }
        [JsonPropertyName("videoPlayComplete")]
        public VideoPlayComplete VideoPlayComplete { get; set; }
        [JsonPropertyName("beacon")]
        public Beacon Beacon { get; set; }
        [JsonPropertyName("postback")]
        public PostBack Postback { get; set; }
    }
}
