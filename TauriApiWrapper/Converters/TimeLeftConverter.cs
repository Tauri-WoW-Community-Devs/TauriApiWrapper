using Newtonsoft.Json;
using System;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Converters
{
    internal sealed class TimeLeftConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeLeft) || objectType == typeof(TimeLeft?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            string value = serializer.Deserialize<string>(reader);
            return value switch
            {
                "LONG" => TimeLeft.Long,
                "MEDIUM" => TimeLeft.Medium,
                "SHORT" => TimeLeft.Short,
                "VERY_LONG" => TimeLeft.VeryLong,
                _ => throw new Exception("Cannot marshal type TimeLeft"),
            };
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            TimeLeft castedValue = (TimeLeft)value;
            switch (castedValue)
            {
                case TimeLeft.Long:
                    serializer.Serialize(writer, "LONG");
                    return;

                case TimeLeft.Medium:
                    serializer.Serialize(writer, "MEDIUM");
                    return;

                case TimeLeft.Short:
                    serializer.Serialize(writer, "SHORT");
                    return;

                case TimeLeft.VeryLong:
                    serializer.Serialize(writer, "VERY_LONG");
                    return;

                default:
                    throw new Exception("Cannot marshal type TimeLeft");
            }
        }
    }
}