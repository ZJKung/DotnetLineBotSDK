using System;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Enums;
using DotnetcoreLineBot.Converters;
using DotnetcoreLineBot.Filters;

namespace DotnetcoreLineBot.Interfaces
{

    public interface IMessage : IRequestMessage
    {
        public LineMessageType Type { get; }
    }
}
