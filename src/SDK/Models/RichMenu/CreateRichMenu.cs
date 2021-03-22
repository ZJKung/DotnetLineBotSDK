using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Models.RichMenu
{
    public class CreateRichMenu
    {
        [JsonPropertyName("richMenuId")]
        public string RichMenuId { get; set; }
        [JsonPropertyName("name")]

        public string Name { get; set; }
        [JsonPropertyName("size")]
        public CreateSize RichMenuSize { get; set; }
        [JsonPropertyName("chatBarText")]
        public string ChatBarText { get; set; }
        [JsonPropertyName("selected")]
        public bool IsSelected { get; set; }
        [JsonPropertyName("areas")]
        public List<CreateArea> Areas { get; set; }
    }
    public class CreateArea
    {
        public CreateArea(int x, int y, int width, int height, IAction _action)
        {
            Bounds = new CreateBounds(x, y, width, height);
            Action = _action;
        }
        [JsonPropertyName("bounds")]
        public CreateBounds Bounds { get; set; }
        [JsonPropertyName("action")]
        public IAction Action { get; set; }
    }

    public class CreateSize
    {
        public CreateSize(int width, int height)
        {
            Width = width;
            Height = height;
        }
        [JsonPropertyName("width")]
        public int Width { get; set; }
        [JsonPropertyName("height")]
        public int Height { get; set; }
    }
    public class CreateBounds
    {
        public CreateBounds(int _x, int _y, int _w, int _h)
        {
            X = _x;
            Y = _y;
            Width = _w;
            Height = _h;
        }
        [JsonPropertyName("x")]
        public int X { get; set; }
        [JsonPropertyName("y")]
        public int Y { get; set; }
        [JsonPropertyName("width")]
        public int Width { get; set; }
        [JsonPropertyName("height")]
        public int Height { get; set; }
    }
}
