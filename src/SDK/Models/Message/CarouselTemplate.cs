using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.Message
{
    public class CarouselTemplate : ITemplate
    {
        public CarouselTemplate(List<CarouselColumnMultipleAction> columns)
        {
            Columns = columns;
        }
        [JsonPropertyName("type")]
        public string Type => "carousel";
        [JsonPropertyName("columns")]
        public List<CarouselColumnMultipleAction> Columns { get; set; }
    }
}
