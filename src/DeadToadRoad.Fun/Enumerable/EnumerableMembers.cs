using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DeadToadRoad.Fun
{
    public static partial class EnumerableMembers
    {
        public static Func<IEnumerable<TA>, bool> All<TA>(Func<TA, bool> p)
        {
            return @as => @as.All(p);
        }

        public static Func<IEnumerable<TA>, IEnumerable<TA>> Append<TA>(Option<TA> a)
        {
            return Concat(a.ToEnumerable());
        }

        public static IEnumerable<TA> Cast<TA>(IEnumerable @as)
        {
            return @as.Cast<TA>();
        }

        public static Func<IEnumerable<TA>, IEnumerable<TA>> Concat<TA>(IEnumerable<TA> range)
        {
            return @as => @as.Concat(range);
        }

        public static Func<IEnumerable<TA>, IEnumerable<TB>> FlatMap<TA, TB>(Func<TA, IEnumerable<TB>> f)
        {
            return @as => @as.SelectMany(f);
        }

        public static IEnumerable<TA> Flatten<TA>(IEnumerable<IEnumerable<TA>> @as)
        {
            return @as.SelectMany(Functions.Identity);
        }

        public static Func<IEnumerable<TA>, IEnumerable<TA>> Prepend<TA>(Option<TA> a)
        {
            return PrependRange(a.ToEnumerable());
        }

        public static Func<IEnumerable<TA>, IEnumerable<TA>> PrependRange<TA>(IEnumerable<TA> range)
        {
            return range.Concat;
        }
    }
}
