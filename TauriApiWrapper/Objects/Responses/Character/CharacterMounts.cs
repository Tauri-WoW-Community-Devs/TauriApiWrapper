using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public class CharacterMounts
    {
        [JsonProperty("mounts")]
        public Mount[] Mounts { get; set; }
    }

    public class Mount
    {
        [JsonProperty("spellid")]
        public long SpellID { get; set; }

        [JsonProperty("spellname")]
        public string SpellName { get; set; }

        [JsonProperty("spellicon")]
        public string SpellIcon { get; set; }

        [JsonProperty("itementry")]
        public long ItemEntryID { get; set; }

        [JsonProperty("quality")]
        public ItemRarity Quality { get; set; }

        [JsonProperty("creatureid")]
        public long CreatureID { get; set; }

        [JsonProperty("modelid")]
        public long ModelID { get; set; }

        [JsonProperty("model_url")]
        public string ModelUrl { get; set; }
    }
}

