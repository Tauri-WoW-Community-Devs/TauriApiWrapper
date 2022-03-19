using Newtonsoft.Json;
using System;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Extensions;

namespace TauriApiWrapper.Converters
{
    internal sealed class RealmNameConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Realm) || objectType == typeof(Realm?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            string value = serializer.Deserialize<string>(reader);

            return value switch
            {
                "[EN] Evermoon" => Realm.Evermoon,
                "[HU] Tauri WoW Server" => Realm.Tauri,
                "[HU] Warriors of Darkness" => Realm.WoD,
                _ => Realm.Evermoon,
            };
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            Realm realm = (Realm)value;

            serializer.Serialize(writer, realm.ToName());

            return;
        }
    }
}