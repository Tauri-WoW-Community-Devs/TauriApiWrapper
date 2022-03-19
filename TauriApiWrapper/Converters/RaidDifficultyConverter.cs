using Newtonsoft.Json;
using System;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Converters
{
    internal sealed class RaidDifficultyConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(RaidDifficulty) || objectType == typeof(RaidDifficulty?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            return value switch
            {
                "10 Player" => RaidDifficulty.TenPlayer,
                "10 Player (Heroic)" => RaidDifficulty.TenPlayerHeroic,
                "25 Player" => RaidDifficulty.TwentyFivePlayer,
                "25 Player (Heroic)" => RaidDifficulty.TwentyFivePlayerHeroic,
                "40 Player" => RaidDifficulty.FortyPlayer,
                "Flexible" => RaidDifficulty.Flexible,
                "Looking For Raid" => RaidDifficulty.LookingForRaid,
                _ => throw new Exception("Cannot marshal type RaidDifficulty"),
            };
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            RaidDifficulty castedValue = (RaidDifficulty)value;
            switch (castedValue)
            {
                case RaidDifficulty.TenPlayer:
                    serializer.Serialize(writer, "10 Player");
                    return;

                case RaidDifficulty.TenPlayerHeroic:
                    serializer.Serialize(writer, "10 Player (Heroic)");
                    return;

                case RaidDifficulty.TwentyFivePlayer:
                    serializer.Serialize(writer, "25 Player");
                    return;

                case RaidDifficulty.TwentyFivePlayerHeroic:
                    serializer.Serialize(writer, "25 Player (Heroic)");
                    return;

                case RaidDifficulty.FortyPlayer:
                    serializer.Serialize(writer, "40 Player");
                    return;

                case RaidDifficulty.Flexible:
                    serializer.Serialize(writer, "Flexible");
                    return;

                case RaidDifficulty.LookingForRaid:
                    serializer.Serialize(writer, "Looking For Raid");
                    return;

                default:
                    throw new Exception("Cannot marshal type TimeLeft");
            }
        }
    }
}