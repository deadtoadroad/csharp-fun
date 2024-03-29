using System.Collections.Generic;
using System.Linq;

namespace DeadToadRoad.Fun
{
    public static partial class EnumerableMembers
    {
        public static IEnumerable<TA> Flatten<TA>(IEnumerable<Option<TA>> @as)
        {
            return @as.SelectMany(OptionMembers.ToEnumerable);
        }
    }
}
