using TauriApiWrapper.Attributes;

namespace TauriApiWrapper.Enums
{
    public enum Realm : byte
    {
        Undefined = 0,

        [Name("Mistblade"), Expansion(Expansion.MistsOfPandaria)]
        Mistblade = 1,

        [Name("[EN] Evermoon"), LinkedRealm(Tauri), Expansion(Expansion.MistsOfPandaria)]
        Evermoon = 2,

        [Name("[HU] Tauri WoW Server"), Expansion(Expansion.MistsOfPandaria)]
        Tauri = 3,

        [Name("[HU] Warriors of Darkness"), Expansion(Expansion.MistsOfPandaria)]
        WoD = 4,

        [Name("Crystalsong"), Expansion(Expansion.WrathOfTheLichKing)]
        Crystalsong = 5,
    }
}