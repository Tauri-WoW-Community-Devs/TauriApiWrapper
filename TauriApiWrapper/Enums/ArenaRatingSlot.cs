using TauriApiWrapper.Attributes;

namespace TauriApiWrapper.Enums
{

    /// <summary>
    /// RATED_BATTLE_SLOT_2v2 = 0,
    /// RATED_BATTLE_SLOT_3v3 = 1,
    /// RATED_BATTLE_SLOT_5v5 = 2,
    /// RATED_BATTLE_SLOT_RATED_BG = 3,
    /// RATED_BATTLE_SLOT_SOLO_3v3 = 4,
    /// MAX_RATED_BG_BATTLE = 5,
    /// RATED_BATTLE_SLOT_PET_BATTLE = 5,
    /// MAX_RATED_BATTLE,
    /// </summary>
    public enum ArenaRatingSlot
    {
        [Name("2v2 Arena")]
        Twos = 0,
        [Name("3v3 Arena")]
        Threes = 1,
        [Name("5v5 Arena")]
        Fives = 2,
        [Name("Rated Battleground")]
        RATED_BATTLE_SLOT_RATED_BG = 3,
        [Name("Solo Queue 3v3")]
        SoloQueue = 4,
        MAX_RATED_BG_BATTLE = 5
    }
}
