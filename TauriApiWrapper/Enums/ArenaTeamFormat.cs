using TauriApiWrapper.Attributes;

namespace TauriApiWrapper.Enums
{
    public enum ArenaTeamFormat
    {
        //    switch (teamSize)
        //{
        //    case 2: teamSize = 0; break;
        //    case 3: teamSize = 1; break;
        //    case 5: teamSize = 2; break;
        //    case 10: teamSize = 3; break;
        //    case 11: teamSize = 4; break;
        //}

        Undefined = 0,
        [Name("2v2")]
        Twos = 2,
        [Name("3v3")]
        Threes = 3,
        [Name("5v5")]
        Fives = 5,
        [Name("Solo Queue")]
        Solo3v3 = 11,
    }
}
