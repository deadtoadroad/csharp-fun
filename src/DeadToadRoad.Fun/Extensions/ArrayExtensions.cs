using System;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Extensions
{
    public static class ArrayExtensions
    {
        public static TA[] Append1<TA>(this TA[] target, TA a)
        {
            return ArrayFunctions.Append1(a)(target);
        }

        public static Func<TA, TA[]> Append2<TA>(this TA[] target, TA a1)
        {
            return Flip<TA, TA, TA[], TA[]>(ArrayFunctions.Append2)(target)(a1);
        }

        public static Func<TA, Func<TA, TA[]>> Append3<TA>(this TA[] target, TA a1)
        {
            return Flip<TA, TA, TA, TA[], TA[]>(ArrayFunctions.Append3)(target)(a1);
        }

        public static Func<TA, Func<TA, Func<TA, TA[]>>> Append4<TA>(this TA[] target, TA a1)
        {
            return Flip<TA, TA, TA, TA, TA[], TA[]>(ArrayFunctions.Append4)(target)(a1);
        }

        public static TA[] AppendN<TA>(this TA[] target, TA[] @as)
        {
            return ArrayFunctions.AppendN(@as)(target);
        }

        public static TA[] Prepend1<TA>(this TA[] target, TA a)
        {
            return ArrayFunctions.Prepend1(a)(target);
        }

        public static Func<TA, TA[]> Prepend2<TA>(this TA[] target, TA a1)
        {
            return Flip<TA, TA, TA[], TA[]>(ArrayFunctions.Prepend2)(target)(a1);
        }

        public static Func<TA, Func<TA, TA[]>> Prepend3<TA>(this TA[] target, TA a1)
        {
            return Flip<TA, TA, TA, TA[], TA[]>(ArrayFunctions.Prepend3)(target)(a1);
        }

        public static Func<TA, Func<TA, Func<TA, TA[]>>> Prepend4<TA>(this TA[] target, TA a1)
        {
            return Flip<TA, TA, TA, TA, TA[], TA[]>(ArrayFunctions.Prepend4)(target)(a1);
        }

        public static TA[] PrependN<TA>(this TA[] target, TA[] @as)
        {
            return ArrayFunctions.PrependN(@as)(target);
        }

        public static Func<TA, TA[]> Prepend2R<TA>(this TA[] target, TA a1)
        {
            return Flip<TA, TA, TA[], TA[]>(ArrayFunctions.Prepend2R)(target)(a1);
        }

        public static Func<TA, Func<TA, TA[]>> Prepend3R<TA>(this TA[] target, TA a1)
        {
            return Flip<TA, TA, TA, TA[], TA[]>(ArrayFunctions.Prepend3R)(target)(a1);
        }

        public static Func<TA, Func<TA, Func<TA, TA[]>>> Prepend4R<TA>(this TA[] target, TA a1)
        {
            return Flip<TA, TA, TA, TA, TA[], TA[]>(ArrayFunctions.Prepend4R)(target)(a1);
        }

        public static TA[] PrependNR<TA>(this TA[] target, TA[] @as)
        {
            return ArrayFunctions.PrependNR(@as)(target);
        }
    }
}
