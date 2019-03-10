using System.Collections.Generic;

namespace TubeHaus.External.Tfl
{
    internal static class EnumerableExtensions
    {
        internal static string ToCsList(this IEnumerable<string> values)
            => string.Join(',', values);
    }
}