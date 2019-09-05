using System;

namespace DeadToadRoad.Fun.Extensions
{
    public static class NullableExtensions
    {
        #region If

        public static Func<Func<TA?, TB>, Option<TB>> IfN<TA, TB>(this TA? a, TA? v)
            where TA : struct
        {
            return Functions.Rotate(Functions.IfN<TA, TB>(v))(a);
        }

        public static Func<Func<TA?, TB>, Option<TB>> IfNotN<TA, TB>(this TA? a, TA? v)
            where TA : struct
        {
            return Functions.Rotate(Functions.IfNotN<TA, TB>(v))(a);
        }

        public static Func<Func<TA?, TB>, TB> IfNUnsafe<TA, TB>(this TA? a, TA? v)
            where TA : struct
        {
            return Functions.Rotate(Functions.IfNUnsafe<TA, TB>(v))(a);
        }

        public static Func<Func<TA?, TB>, TB> IfNotNUnsafe<TA, TB>(this TA? a, TA? v)
            where TA : struct
        {
            return Functions.Rotate(Functions.IfNotNUnsafe<TA, TB>(v))(a);
        }

        #endregion

        #region Predicates

        public static bool IsNullable<TA>(this TA a)
        {
            return Functions.IsNullable(a);
        }

        public static bool IsNotNullable<TA>(this TA a)
        {
            return Functions.IsNotNullable(a);
        }

        public static bool HasValue<TA>(this TA? a)
            where TA : struct
        {
            return Functions.HasValue(a);
        }

        public static bool HasNotValue<TA>(this TA? a)
            where TA : struct
        {
            return Functions.HasNotValue(a);
        }

        #endregion
    }
}
