using System;
using System.Linq;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Extensions;

namespace TauriApiWrapper.Code
{
    internal static class ArenaFormatConverter
    {
        public static ArenaTeamFormat GetArenaTeamFormat(string value)
        {
            foreach (ArenaTeamFormat item in Enum.GetValues(typeof(ArenaTeamFormat)).Cast<ArenaTeamFormat>())
            {
                if (item == ArenaTeamFormat.Undefined)
                    continue;

                if (item.ToName().Equals(value, StringComparison.OrdinalIgnoreCase))
                    return item;
            }

            return ArenaTeamFormat.Undefined;
        }
    }
}
