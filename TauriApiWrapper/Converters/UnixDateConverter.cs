using Newtonsoft.Json;
using System;
using TauriApiWrapper.Extensions;

namespace TauriApiWrapper.Converters
{
    internal sealed class UnixDateConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(double) || objectType == typeof(double?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            long value = serializer.Deserialize<long>(reader);

            return DateTimeOffset.FromUnixTimeSeconds(value).UtcDateTime;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            double unixValue = (double)value;

            serializer.Serialize(writer, unixValue);

            return;
        }
    }
}