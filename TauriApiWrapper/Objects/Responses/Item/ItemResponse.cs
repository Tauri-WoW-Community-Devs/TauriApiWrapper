using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Item
{
    public sealed class ItemResponse : BaseApiResponse
    {
        [JsonProperty("SocketContainedMask")]
        public int SocketContainedMask { get; set; }

        [JsonProperty("curDurability")]
        public long CurrentDurability { get; set; }

        [JsonProperty("creatorName")]
        public string CreatorName { get; set; }

        [JsonProperty("pernamentEnchDesc")]
        public string PernamentEnchDesc { get; set; }

        [JsonProperty("SocketBonusDesc")]
        public string SocketBonusDesc { get; set; }

        [JsonProperty("AllowedClassesStr")]
        public string AllowedClasses { get; set; }

        [JsonProperty("AllowedRacesStr")]
        public string AllowedRaces { get; set; }

        [JsonProperty("ReqSkillStr")]
        public string ReqSkill { get; set; }

        [JsonProperty("ReqSkillRank")]
        public int ReqSkillRank { get; set; }

        [JsonProperty("SocketContainedGem")]
        public object[] SocketContainedGem { get; set; }

        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("_Class")]
        public Class Class { get; set; }

        [JsonProperty("_SubClass")]
        public int SubClass { get; set; }

        [JsonProperty("DisplayID")]
        public int DisplayID { get; set; }

        [JsonProperty("InventoryType")]
        public int InventoryType { get; set; }

        [JsonProperty("Quality_orig")]
        public int QualityOrig { get; set; }

        [JsonProperty("Quality")]
        public ItemRarity Quality { get; set; }

        [JsonProperty("Flags")]
        public int Flags { get; set; }

        [JsonProperty("Flags2")]
        public int Flags2 { get; set; }

        [JsonProperty("Flags3")]
        public int Flags3 { get; set; }

        [JsonProperty("BuyCount")]
        public int BuyCount { get; set; }

        [JsonProperty("BuyPrice")]
        public int BuyPrice { get; set; }

        [JsonProperty("SellPrice")]
        public int SellPrice { get; set; }

        [JsonProperty("ItemLevel")]
        public int ItemLevel { get; set; }

        [JsonProperty("MaxCount")]
        public int MaxCount { get; set; }

        [JsonProperty("Stackable")]
        public bool Stackable { get; set; }

        [JsonProperty("ContainerSlots")]
        public int ContainerSlots { get; set; }

        [JsonProperty("ScalingStatDistribution")]
        public int ScalingStatDistribution { get; set; }

        [JsonProperty("Delay")]
        public int Delay { get; set; }

        [JsonProperty("RangedModRange")]
        public int RangedModRange { get; set; }

        [JsonProperty("Bonding")]
        public int Bonding { get; set; }

        [JsonProperty("originalname")]
        public string Originalname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("RandomProperty")]
        public int RandomProperty { get; set; }

        [JsonProperty("RandomSuffix")]
        public int RandomSuffix { get; set; }

        [JsonProperty("ItemSet")]
        public int ItemSet { get; set; }

        [JsonProperty("SocketBonus")]
        public int SocketBonus { get; set; }

        [JsonProperty("GemProperties")]
        public int GemProperties { get; set; }

        [JsonProperty("m_inventoryIconOriginal")]
        public string InventoryIconOriginal { get; set; }

        [JsonProperty("m_inventoryIcon")]
        public string InventoryIcon { get; set; }

        [JsonProperty("m_className")]
        public string ClassName { get; set; }

        [JsonProperty("m_subClassName")]
        public string SubClassName { get; set; }

        [JsonProperty("BaseMinDamage")]
        public float BaseMinDamage { get; set; }

        [JsonProperty("BaseMaxDamage")]
        public float BaseMaxDamage { get; set; }

        [JsonProperty("BaseTypeDamage")]
        public float BaseTypeDamage { get; set; }

        [JsonProperty("ExtraMinDamage")]
        public float ExtraMinDamage { get; set; }

        [JsonProperty("ExtraMaxDamage")]
        public float ExtraMaxDamage { get; set; }

        [JsonProperty("ExtraTypeDamage")]
        public float ExtraTypeDamage { get; set; }

        [JsonProperty("MaxDurability")]
        public int MaxDurability { get; set; }

        [JsonProperty("RequiredLevel")]
        public int RequiredLevel { get; set; }

        [JsonProperty("RequiredSkill")]
        public int RequiredSkill { get; set; }

        [JsonProperty("RequiredSkillRank")]
        public int RequiredSkillRank { get; set; }

        [JsonProperty("RequiredSpell")]
        public int RequiredSpell { get; set; }

        [JsonProperty("RequiredHonorRank")]
        public int RequiredHonorRank { get; set; }

        [JsonProperty("RequiredCityRank")]
        public int RequiredCityRank { get; set; }

        [JsonProperty("RequiredReputationFaction")]
        public int RequiredReputationFaction { get; set; }

        [JsonProperty("RequiredReputationRank")]
        public int RequiredReputationRank { get; set; }

        [JsonProperty("Armory")]
        public int Armor { get; set; }

        [JsonProperty("SpellTrigger")]
        public long[] SpellTrigger { get; set; }

        [JsonProperty("SpellID")]
        public object[] SpellID { get; set; }

        [JsonProperty("ItemStat")]
        public ItemStat[] ItemStat { get; set; }

        [JsonProperty("Socket")]
        public Socket[] Socket { get; set; }

        [JsonProperty("itemsetInfo")]
        public string ItemSetInfoHtml { get; set; }

        [JsonProperty("ItemSetInfo")]
        public ItemSetInfo ItemSetInfo { get; set; }

        [JsonProperty("item_equip")]
        public string ItemEquip { get; set; }

        [JsonProperty("armor_type")]
        public string ArmorType { get; set; }

        [JsonProperty("weapon_damage")]
        public bool WeaponDamage { get; set; }

        [JsonProperty("minDmg")]
        public float MinDmg { get; set; }

        [JsonProperty("maxDmg")]
        public float MaxDmg { get; set; }

        [JsonProperty("dmg_speed")]
        public float DmgSpeed { get; set; }

        [JsonProperty("ench")]
        public string Ench { get; set; }

        [JsonProperty("item_armor")]
        public string ItemArmor { get; set; }

        [JsonProperty("quality_color_original")]
        public string QualityColorOriginal { get; set; }

        [JsonProperty("quality_color")]
        public string QualityColor { get; set; }

        [JsonProperty("item_name_original")]
        public string ItemNameOriginal { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("description")]
        public string TemperaturesDescription { get; set; }

        [JsonProperty("is_heroic")]
        public bool IsHeroic { get; set; }

        [JsonProperty("bonding")]
        public string TemperaturesBonding { get; set; }

        [JsonProperty("haveCreator")]
        public bool HaveCreator { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("races")]
        public string Races { get; set; }

        [JsonProperty("classes")]
        public string Classes { get; set; }

        [JsonProperty("need_level")]
        public int NeedLevel { get; set; }

        [JsonProperty("need_skill")]
        public string NeedSkill { get; set; }

        [JsonProperty("need_skill_rank")]
        public int NeedSkillRank { get; set; }

        [JsonProperty("need_reputation_rank")]
        public string NeedReputationRank { get; set; }

        [JsonProperty("need_reputation_faction")]
        public string NeedReputationFaction { get; set; }

        [JsonProperty("durability")]
        public Durability Durability { get; set; }

        [JsonProperty("startquesto")]
        public int StartQuesto { get; set; }

        [JsonProperty("fullLootInfo")]
        public string FullLootInfo { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("itemLevel")]
        public int TemperaturesItemLevel { get; set; }

        [JsonProperty("transmogid")]
        public int TransmogID { get; set; }

        [JsonProperty("transmogitemname")]
        public string TransmogItemName { get; set; }

        [JsonProperty("transmogitemicon")]
        public string TransmogItemIcon { get; set; }

        [JsonProperty("upgradeid")]
        public int UpgradeID { get; set; }

        [JsonProperty("upgradelevel")]
        public int Upgradelevel { get; set; }

        [JsonProperty("upgrademaxlevel")]
        public int UpgradeMaxLevel { get; set; }

        [JsonProperty("upgradetext")]
        public string UpgradeText { get; set; }

        [JsonProperty("itemnamedescription")]
        public string ItemNameDescription { get; set; }

        [JsonProperty("useenchantment")]
        public string UseEnchantment { get; set; }
    }
}