using System;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Enums;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Action
{
    public class DatetimePickerAction : IAction
    {
        [JsonPropertyName("type")]
        public ActionType Type => ActionType.datetimepicker;
        [JsonPropertyName("label")]
        public string Label { get; set; }
    }
}
