using Newtonsoft.Json;
using System;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Converters
{
    internal sealed class BattlePetTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(BattlePetType) || objectType == typeof(BattlePetType?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            string value = serializer.Deserialize<string>(reader);
            return value switch
            {
                "Aquatic" => BattlePetType.Aquatic,
                "Beast" => BattlePetType.Beast,
                "Critter" => BattlePetType.Critter,
                "Dragonkin" => BattlePetType.Dragonkin,
                "Elemental" => BattlePetType.Elemental,
                "Flying" => BattlePetType.Flying,
                "Humanoid" => BattlePetType.Humanoid,
                "Magic" => BattlePetType.Magic,
                "Mechanical" => BattlePetType.Mechanical,
                "Undead" => BattlePetType.Undead,
                _ => throw new Exception("Cannot unmarshal type PetTypeName"),
            };
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            BattlePetType realm = (BattlePetType)value;

            serializer.Serialize(writer, realm.ToString());

            return;
        }
    }
}