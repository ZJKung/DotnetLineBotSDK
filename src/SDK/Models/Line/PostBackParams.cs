using System.Text.Json.Serialization;

namespace DotnetcoreLineBot.Models.Line
{
    public class PostBackParams
    {
        [JsonPropertyName("datatime")]
        public string Datetime { get; set; }
    }
}