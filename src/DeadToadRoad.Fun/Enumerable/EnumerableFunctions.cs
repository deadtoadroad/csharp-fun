using System;
using System.Collections.Generic;
using DeadToadRoad.Fun.Extensions;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region Factories

        public static Func<TValue, Option<KeyValuePair<TKey, TValue>>> Kvp<TKey, TValue>(TKey key)
        {
            return value => key.ToOption()
                .FlatMap(k => value.ToOption()
                    .Map(v => new KeyValuePair<TKey, TValue>(key, value))
                );
        }

        public static Option<KeyValuePair<TKey, TValue>> Kvp<TKey, TValue>(TKey key, TValue value)
        {
            return Kvp<TKey, TValue>(key)(value);
        }

        public static IEnumerable<TA> Nil<TA>()
        {
            yield break;
        }

        #endregion
    }
}
