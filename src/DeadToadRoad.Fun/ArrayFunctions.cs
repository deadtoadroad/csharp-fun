using System;

namespace DeadToadRoad.Fun
{
    public static class ArrayFunctions
    {
        public static Func<TA[], TA[]> Append<TA>(TA a)
        {
            return Append(new[] {a});
        }

        public static Func<TA[], TA[]> Append<TA>(TA[] @as)
        {
            return target => {
                var t = target ?? new TA[0];
                var a = @as ?? new TA[0];
                var r = new TA[t.Length + a.Length];
                Array.Copy(t, r, t.Length);
                Array.Copy(a, 0, r, t.Length, a.Length);
                return r;
            };
        }

        public static Func<TA[], TA[]> Prepend<TA>(TA a)
        {
            return Prepend(new[] {a});
        }

        public static Func<TA[], TA[]> Prepend<TA>(TA[] @as)
        {
            return Functions.Flip<TA[], TA[], TA[]>(Append)(@as);
        }
    }
}
