using Newtonsoft.Json;
using System;

namespace TauriApiWrapper.Converters
{
    internal sealed class TimeSpanSecondsConverter : JsonConverter
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

            return TimeSpan.FromSeconds(value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            TimeSpan timeSpan = (TimeSpan)value;

            serializer.Serialize(writer, timeSpan.TotalSeconds);

            return;
        }
    }
}