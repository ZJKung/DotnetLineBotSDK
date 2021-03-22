using System;
using DotnetcoreLineBot.Enums;

namespace DotnetcoreLineBot.Interfaces
{
    public interface IAction
    {
        public ActionType Type { get; }
        public string Label { get; set; }
    }
}
