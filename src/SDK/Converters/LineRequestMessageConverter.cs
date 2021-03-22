using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotnetcoreLineBot.Interfaces;

namespace DotnetcoreLineBot.Converters
{
    public class LineRequestMessageConverter : JsonConverter<IRequestMessage>
    {
        public override IMessage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, IRequestMessage value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case null:
                    JsonSerializer.Serialize(writer, (IRequestMessage)null, options);
                    break;
                default:
                    {
                        var type = value.GetType();
                        JsonSerializer.Serialize(writer, value, type, options);
                        break;
                    }
            }
        }
    }
}
