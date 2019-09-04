using System;
using System.Collections.Generic;

namespace DeadToadRoad.Fun
{
    public static class OptionMembers
    {
        public static bool IsSome<TA>(Option<TA> a)
        {
            return a.IsSome;
        }

        public static bool IsNone<TA>(Option<TA> a)
        {
            return a.IsNone;
        }

        public static Func<Option<TA>, Option<TA>> Filter<TA>(Func<TA, bool> p)
        {
            return a => a.Filter(p);
        }

        public static Func<Option<TA>, Option<TB>> FlatMap<TA, TB>(Func<TA, Option<TB>> f)
        {
            return a => a.FlatMap(f);
        }

        public static Func<Option<TA>, TA> GetOrElse<TA>(TA @else)
        {
            return a => a.GetOrElse(@else);
        }

        public static Func<Option<TA>, TA> GetOrElse<TA>(Func<TA> @else)
        {
            return a => a.GetOrElse(@else);
        }

        public static TA GetUnsafe<TA>(Option<TA> a)
        {
            return a.GetUnsafe();
        }

        public static Func<Option<TA>, Option<TB>> Map<TA, TB>(Func<TA, TB> f)
        {
            return a => a.Map(f);
        }

        public static TA[] ToArray<TA>(Option<TA> a)
        {
            return a.ToArray();
        }

        public static IList<TA> ToList<TA>(Option<TA> a)
        {
            return a.ToList();
        }
    }
}
