using System;
using System.Collections.Generic;
using System.Linq;

namespace DeadToadRoad.Fun.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TB> FlatMap<TA, TB>(this IEnumerable<TA> @as, Func<TA, IEnumerable<TB>> f)
        {
            return @as.SelectMany(f);
        }

        public static IEnumerable<TA> Flatten<TA>(this IEnumerable<IEnumerable<TA>> @as)
        {
            return @as.SelectMany(Functions.Identity);
        }

        public static IEnumerable<TB> Map<TA, TB>(this IEnumerable<TA> @as, Func<TA, TB> f)
        {
            return @as.Select(f);
        }
    }
}
