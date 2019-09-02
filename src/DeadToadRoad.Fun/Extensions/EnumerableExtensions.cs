using System;
using System.Collections.Generic;
using System.Linq;

namespace DeadToadRoad.Fun.Extensions
{
    public static class EnumerableExtensions
    {
        #region FlatMap

        public static IEnumerable<TB> FlatMap<TA, TB>(this IEnumerable<TA> @as, Func<TA, IEnumerable<TB>> f)
        {
            return @as.SelectMany(f);
        }

        #endregion

        #region Flatten

        public static IEnumerable<TA> Flatten<TA>(this IEnumerable<IEnumerable<TA>> @as)
        {
            return @as.SelectMany(Functions.Identity);
        }

        #endregion

        #region AppendRange

        public static IEnumerable<TA> AppendRange<TA>(this IEnumerable<TA> @as, IEnumerable<TA> range)
        {
            return Functions.AppendRange(range)(@as);
        }

        public static IEnumerable<TA> PrependRange<TA>(this IEnumerable<TA> @as, IEnumerable<TA> range)
        {
            return Functions.PrependRange(range)(@as);
        }

        #endregion
    }
}
