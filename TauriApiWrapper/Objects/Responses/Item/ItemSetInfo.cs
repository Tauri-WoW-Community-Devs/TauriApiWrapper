using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Item
{
    public sealed class ItemSetInfo
    {
        [JsonProperty("base")]
        public ItemSetData Base { get; set; }
    }


    public sealed class ItemSetData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reqSkill")]
        public long ReqSkill { get; set; }

        [JsonProperty("reqValue")]
        public long ReqValue { get; set; }

        [JsonProperty("Spells")]
        public SetSpell[] Spells { get; set; }

        [JsonProperty("Items")]
        public SetItem[] Items { get; set; }
    }

    public sealed class SetItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("invType")]
        public int InvType { get; set; }

        [JsonProperty("have")]
        public bool Have { get; set; }
    }

    public sealed class SetSpell
    {
        [JsonProperty("spell")]
        public string SpellSpell { get; set; }

        [JsonProperty("threshold")]
        public long Threshold { get; set; }
    }

}