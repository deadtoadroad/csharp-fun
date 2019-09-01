using System;

namespace DeadToadRoad.Fun.Extensions
{
    public static class NullableExtensions
    {
        #region If

        public static Func<Func<TA?, TB>, Option<TB>> If<TA, TB>(this TA? a, TA? v)
            where TA : struct
        {
            return f => Functions.If<TA, TB>(v)(f)(a);
        }

        public static Func<Func<TA?, TB>, Option<TB>> IfNot<TA, TB>(this TA? a, TA? v)
            where TA : struct
        {
            return f => Functions.IfNot<TA, TB>(v)(f)(a);
        }

        #endregion

        #region Predicates

        public static bool HasValue<TA>(TA? a)
            where TA : struct
        {
            return Functions.HasValue(a);
        }

        public static bool HasNotValue<TA>(TA? a)
            where TA : struct
        {
            return Functions.HasNotValue(a);
        }

        #endregion
    }
}
