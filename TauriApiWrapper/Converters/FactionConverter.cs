using Newtonsoft.Json;
using System;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Converters
{
    internal sealed class FactionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Faction) || objectType == typeof(Faction?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            string value = serializer.Deserialize<string>(reader);

            return value switch
            {
                "Horde" => Faction.Horde,
                "Alliance" => Faction.Alliance,
                _ => throw new NotImplementedException("Unexpected realm name"),
            };
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            Faction faction = (Faction)value;

            serializer.Serialize(writer, faction.ToString());

            return;
        }
    }
}