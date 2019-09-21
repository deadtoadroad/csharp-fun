using System;
using System.Collections.Generic;

namespace DeadToadRoad.Fun
{
    public static partial class EnumerableMembers
    {
        public static Func<TValue, Func<IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>>> Append<TKey, TValue>(TKey key)
        {
            return Functions.Compose(Append, Functions.Kvp<TKey, TValue>(key));
        }

        public static Func<IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>> Append<TKey, TValue>(TKey key, TValue value)
        {
            return Append<TKey, TValue>(key)(value);
        }

        public static Func<TValue, Func<IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>>> Prepend<TKey, TValue>(TKey key)
        {
            return Functions.Compose(Prepend, Functions.Kvp<TKey, TValue>(key));
        }

        public static Func<IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>> Prepend<TKey, TValue>(TKey key, TValue value)
        {
            return Prepend<TKey, TValue>(key)(value);
        }
    }
}
