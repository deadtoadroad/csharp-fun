using System;

namespace DeadToadRoad.Fun.Extensions
{
    public static class NullableExtensions
    {
        #region If

        public static Func<Func<TA, TB>, Option<TB>> IfN<TA, TB>(this TA? a, TA v)
            where TA : struct
        {
            return Functions.Flip(Functions.IfN<TA, TB>(v))(a);
        }

        public static Func<Func<TA, TB>, Option<TB>> IfNotN<TA, TB>(this TA? a, TA v)
            where TA : struct
        {
            return Functions.Flip(Functions.IfNotN<TA, TB>(v))(a);
        }

        public static Func<Func<TA, TB>, TB> IfNUnsafe<TA, TB>(this TA? a, TA v)
            where TA : struct
        {
            return Functions.Flip(Functions.IfNUnsafe<TA, TB>(v))(a);
        }

        public static Func<Func<TA, TB>, TB> IfNotNUnsafe<TA, TB>(this TA? a, TA v)
            where TA : struct
        {
            return Functions.Flip(Functions.IfNotNUnsafe<TA, TB>(v))(a);
        }

        #endregion

        #region Map

        public static Func<Func<TB>, TB> BiMapN<TA, TB>(this TA? a, Func<TA, TB> f)
            where TA : struct
        {
            return Functions.Flip(Functions.BiMapN(f))(a);
        }

        public static TB MapUnsafeN<TA, TB>(this TA? a, Func<TA, TB> f)
            where TA : struct
        {
            return Functions.MapUnsafeN(f)(a);
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