using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public sealed class GuildBankItem
    {
        [JsonProperty("tid")]
        public int TID { get; set; }

        [JsonProperty("tabid")]
        public string TabID { get; set; }

        [JsonProperty("sid")]
        public long SID { get; set; }

        [JsonProperty("entry")]
        public int Entry { get; set; }

        [JsonProperty("Quality_original")]
        public int QualityOriginal { get; set; }

        [JsonProperty("Quality")]
        public ItemRarity Quality { get; set; }

        [JsonProperty("name_original")]
        public string NameOriginal { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("classname")]
        public string ItemType { get; set; }

        [JsonProperty("subclassname")]
        public string Subclassname { get; set; }

        [JsonProperty("icon_original")]
        public string IconOriginal { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("stackcount")]
        public int StackCount { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("slotid")]
        public string SlotID { get; set; }
    }
}