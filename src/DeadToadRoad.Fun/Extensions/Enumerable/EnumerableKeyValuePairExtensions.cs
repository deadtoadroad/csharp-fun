using System;
using System.Collections.Generic;

namespace DeadToadRoad.Fun.Extensions
{
    public static class EnumerableKeyValuePairExtensions
    {
        #region Members

        public static Func<TValue, IEnumerable<KeyValuePair<TKey, TValue>>> Append<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> kvps, TKey key)
        {
            return Functions.RotateRight2(EnumerableMembers.Append<TKey, TValue>(key))(kvps);
        }

        public static IEnumerable<KeyValuePair<TKey, TValue>> Append<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> kvps, TKey key, TValue value)
        {
            return EnumerableMembers.Append(key, value)(kvps);
        }

        public static Func<TValue, IEnumerable<KeyValuePair<TKey, TValue>>> Prepend<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> kvps, TKey key)
        {
            return Functions.RotateRight2(EnumerableMembers.Prepend<TKey, TValue>(key))(kvps);
        }

        public static IEnumerable<KeyValuePair<TKey, TValue>> Prepend<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> kvps, TKey key, TValue value)
        {
            return EnumerableMembers.Prepend(key, value)(kvps);
        }

        #endregion
    }
}
