using System;

namespace TauriApiWrapper.Extensions
{
    internal static class DateTimeExtensions
    {
        private readonly static DateTime _Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime FromUnixTimeStamp(this double value)
        {
            return _Epoch.AddSeconds(value).ToLocalTime();
        }
    }
}