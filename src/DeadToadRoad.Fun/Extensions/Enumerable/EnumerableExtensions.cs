using System;
using System.Collections.Generic;

namespace DeadToadRoad.Fun.Extensions
{
    public static class EnumerableExtensions
    {
        #region Members

        public static IEnumerable<TB> FlatMap<TA, TB>(this IEnumerable<TA> @as, Func<TA, IEnumerable<TB>> f)
        {
            return EnumerableMembers.FlatMap(f)(@as);
        }

        public static IEnumerable<TA> Flatten<TA>(this IEnumerable<IEnumerable<TA>> @as)
        {
            return EnumerableMembers.Flatten(@as);
        }

        public static IEnumerable<TA> PrependRange<TA>(this IEnumerable<TA> @as, IEnumerable<TA> range)
        {
            return EnumerableMembers.PrependRange(range)(@as);
        }

        #endregion
    }
}
