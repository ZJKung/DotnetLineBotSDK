using DotnetcoreLineBot.Converters;
using DotnetcoreLineBot.Filters;

namespace DotnetcoreLineBot.Interfaces
{
    [JsonInterfaceConverter(typeof(LineRequestMessageConverter))]
    public interface IRequestMessage
    {
    }
}