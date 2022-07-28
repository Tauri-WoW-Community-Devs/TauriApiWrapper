using System;
using TauriApiWrapper.Attributes;

namespace TauriApiWrapper.Enums
{
    public enum OldRaidDifficulty
    {
        [Name("10 N")]
        TenPlayer = 0,
        [Name("25 N")]
        TwentyFivePlayer = 1,
        [Name("10 HC")]
        TenPlayerHeroic = 2,
        [Name("25 HC")]
        TwentyFivePlayerHeroic = 3,
    }

    public static class OldRaidDifficultyExtensions
    {
        public static RaidDifficulty NormalizeDiff(this OldRaidDifficulty value)
        {
            return value switch
            {
                OldRaidDifficulty.TenPlayer => RaidDifficulty.TenPlayer,
                OldRaidDifficulty.TwentyFivePlayer => RaidDifficulty.TwentyFivePlayer,
                OldRaidDifficulty.TenPlayerHeroic => RaidDifficulty.TenPlayerHeroic,
                OldRaidDifficulty.TwentyFivePlayerHeroic => RaidDifficulty.TwentyFivePlayerHeroic,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
