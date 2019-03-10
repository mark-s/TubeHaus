using System;

namespace TubeHaus.External.Tfl
{
    internal static class DateTimeExtensions
    {
        internal static string ToTflShortDate(this DateTime dateTime)
            => dateTime.ToString("yyyy-MM-dd");
    }
}
