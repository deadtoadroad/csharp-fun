using System;

namespace DeadToadRoad.Fun
{
    public static class ArrayFunctions
    {
        public static Func<TA[], TA[]> Append1<TA>(TA a)
        {
            return AppendN(new[] {a});
        }

        public static Func<TA, Func<TA[], TA[]>> Append2<TA>(TA a1)
        {
            return a2 => AppendN(new[] {a1, a2});
        }

        public static Func<TA, Func<TA, Func<TA[], TA[]>>> Append3<TA>(TA a1)
        {
            return a2 => a3 => AppendN(new[] {a1, a2, a3});
        }

        public static Func<TA, Func<TA, Func<TA, Func<TA[], TA[]>>>> Append4<TA>(TA a1)
        {
            return a2 => a3 => a4 => AppendN(new[] {a1, a2, a3, a4});
        }

        public static Func<TA[], TA[]> AppendN<TA>(TA[] @as)
        {
            return target => PrependN(target)(@as);
        }

        public static Func<TA[], TA[]> Prepend1<TA>(TA a)
        {
            return PrependN(new[] {a});
        }

        public static Func<TA, Func<TA[], TA[]>> Prepend2<TA>(TA a1)
        {
            return a2 => PrependN(new[] {a2, a1});
        }

        public static Func<TA, Func<TA, Func<TA[], TA[]>>> Prepend3<TA>(TA a1)
        {
            return a2 => a3 => PrependN(new[] {a3, a2, a1});
        }

        public static Func<TA, Func<TA, Func<TA, Func<TA[], TA[]>>>> Prepend4<TA>(TA a1)
        {
            return a2 => a3 => a4 => PrependN(new[] {a4, a3, a2, a1});
        }

        public static Func<TA[], TA[]> PrependN<TA>(TA[] @as)
        {
            return PrependNInternal<TA>(a => r => Array.Copy(a, r, a.Length))(@as);
        }

        public static Func<TA, Func<TA[], TA[]>> Prepend2R<TA>(TA a1)
        {
            return a2 => PrependNR(new[] {a2, a1});
        }

        public static Func<TA, Func<TA, Func<TA[], TA[]>>> Prepend3R<TA>(TA a1)
        {
            return a2 => a3 => PrependNR(new[] {a3, a2, a1});
        }

        public static Func<TA, Func<TA, Func<TA, Func<TA[], TA[]>>>> Prepend4R<TA>(TA a1)
        {
            return a2 => a3 => a4 => PrependNR(new[] {a4, a3, a2, a1});
        }

        public static Func<TA[], TA[]> PrependNR<TA>(TA[] @as)
        {
            return PrependNInternal<TA>(a => r => {
                // Copy a to r in reverse.
                for (var i = 0; i < a.Length; i++)
                    r[i] = a[a.Length - i - 1];
            })(@as);
        }

        private static Func<TA[], Func<TA[], TA[]>> PrependNInternal<TA>(Func<TA[], Action<TA[]>> copy)
        {
            return @as => target => {
                var a = @as ?? new TA[0];
                var t = target ?? new TA[0];
                var r = new TA[a.Length + t.Length];
                copy(a)(r);
                Array.Copy(t, 0, r, a.Length, t.Length);
                return r;
            };
        }
    }
}
