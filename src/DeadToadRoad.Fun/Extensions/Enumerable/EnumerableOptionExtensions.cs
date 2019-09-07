using System.Collections.Generic;

namespace DeadToadRoad.Fun.Extensions
{
    public static class EnumerableOptionExtensions
    {
        #region Members

        public static IEnumerable<TA> Flatten<TA>(this IEnumerable<Option<TA>> @as)
        {
            return EnumerableMembers.Flatten(@as);
        }

        #endregion
    }
}
