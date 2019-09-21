using System;
using System.Collections.Generic;

namespace DeadToadRoad.Fun.Extensions
{
    public static class EnumerableExtensions
    {
        #region Factories

        public static Option<KeyValuePair<TKey, TValue>> Kvp<TKey, TValue>(this TValue value, TKey key)
        {
            return Functions.Kvp(key, value);
        }

        #endregion

        #region Members

        public static IEnumerable<TA> Append<TA>(this IEnumerable<TA> @as, Option<TA> a)
        {
            return EnumerableMembers.Append(a)(@as);
        }

        public static IEnumerable<TB> FlatMap<TA, TB>(this IEnumerable<TA> @as, Func<TA, IEnumerable<TB>> f)
        {
            return EnumerableMembers.FlatMap(f)(@as);
        }

        public static IEnumerable<TA> Flatten<TA>(this IEnumerable<IEnumerable<TA>> @as)
        {
            return EnumerableMembers.Flatten(@as);
        }

        public static IEnumerable<TA> Prepend<TA>(this IEnumerable<TA> @as, Option<TA> a)
        {
            return EnumerableMembers.Prepend(a)(@as);
        }

        public static IEnumerable<TA> PrependRange<TA>(this IEnumerable<TA> @as, IEnumerable<TA> range)
        {
            return EnumerableMembers.PrependRange(range)(@as);
        }

        #endregion
    }
}
