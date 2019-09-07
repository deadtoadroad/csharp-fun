using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DeadToadRoad.Fun
{
    public static class EnumerableMembers
    {
        public static Func<IEnumerable<TA>, bool> All<TA>(Func<TA, bool> p)
        {
            return @as => @as.All(p);
        }

        public static IEnumerable<TA> Cast<TA>(IEnumerable @as)
        {
            return @as.Cast<TA>();
        }
    }
}
