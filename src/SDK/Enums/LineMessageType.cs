using System;
using System.Text.Json.Serialization;

namespace DotnetcoreLineBot.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LineMessageType
    {
        text,
        sticker,
        image,
        video,
        audio,
        template,
        flex,
        location
    }
}
