using System.Text.Json.Serialization;
using DotnetcoreLineBot.Enums;

namespace DotnetcoreLineBot.Models.Line
{
    public class Beacon
    {
        [JsonPropertyName("hwId")]
        public string HwId { get; set; }
        [JsonPropertyName("type")]
        public BeaconType Type { get; set; }
    }
}