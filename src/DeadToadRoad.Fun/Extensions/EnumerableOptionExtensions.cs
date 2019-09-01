using System.Collections.Generic;

namespace DeadToadRoad.Fun.Extensions
{
    public static class EnumerableOptionExtensions
    {
        #region Flatten

        public static IEnumerable<TA> Flatten<TA>(this IEnumerable<Option<TA>> @as)
        {
            return Functions.Flatten(@as);
        }

        #endregion
    }
}
