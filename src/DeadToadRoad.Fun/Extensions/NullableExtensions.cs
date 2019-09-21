using System;

namespace DeadToadRoad.Fun.Extensions
{
    public static class NullableExtensions
    {
        #region If

        public static Option<TA> IfN<TA>(this TA? a, Func<TA, bool> p)
            where TA : struct
        {
            return Functions.IfN(p)(a);
        }

        public static Option<TA> IfN<TA>(this TA? a, TA v)
            where TA : struct
        {
            return Functions.IfN(v)(a);
        }

        public static Option<TA> IfNotN<TA>(this TA? a, TA v)
            where TA : struct
        {
            return Functions.IfNotN(v)(a);
        }

        public static Func<Func<TA, TB>, Option<TB>> IfMapN<TA, TB>(this TA? a, Func<TA, bool> p)
            where TA : struct
        {
            return Functions.RotateRight2(Functions.IfMapN<TA, TB>(p))(a);
        }

        public static Option<TB> IfMapN<TA, TB>(this TA? a, Func<TA, bool> p, Func<TA, TB> f)
            where TA : struct
        {
            return Functions.IfMapN(p, f)(a);
        }

        public static Func<Func<TA, TB>, Option<TB>> IfMapN<TA, TB>(this TA? a, TA v)
            where TA : struct
        {
            return Functions.RotateRight2(Functions.IfMapN<TA, TB>(v))(a);
        }

        public static Option<TB> IfMapN<TA, TB>(this TA? a, TA v, Func<TA, TB> f)
            where TA : struct
        {
            return Functions.IfMapN(v, f)(a);
        }

        public static Func<Func<TA, TB>, Option<TB>> IfNotMapN<TA, TB>(this TA? a, TA v)
            where TA : struct
        {
            return Functions.RotateRight2(Functions.IfNotMapN<TA, TB>(v))(a);
        }

        public static Option<TB> IfNotMapN<TA, TB>(this TA? a, TA v, Func<TA, TB> f)
            where TA : struct
        {
            return Functions.IfNotMapN(v, f)(a);
        }

        public static Func<Func<TA, TB>, TB> IfMapUnsafeN<TA, TB>(this TA? a, Func<TA, bool> p)
            where TA : struct
        {
            return Functions.RotateRight2(Functions.IfMapUnsafeN<TA, TB>(p))(a);
        }

        public static TB IfMapUnsafeN<TA, TB>(this TA? a, Func<TA, bool> p, Func<TA, TB> f)
            where TA : struct
        {
            return Functions.IfMapUnsafeN(p, f)(a);
        }

        public static Func<Func<TA, TB>, TB> IfMapUnsafeN<TA, TB>(this TA? a, TA v)
            where TA : struct
        {
            return Functions.RotateRight2(Functions.IfMapUnsafeN<TA, TB>(v))(a);
        }

        public static TB IfMapUnsafeN<TA, TB>(this TA? a, TA v, Func<TA, TB> f)
            where TA : struct
        {
            return Functions.IfMapUnsafeN(v, f)(a);
        }

        public static Func<Func<TA, TB>, TB> IfNotMapUnsafeN<TA, TB>(this TA? a, TA v)
            where TA : struct
        {
            return Functions.RotateRight2(Functions.IfNotMapUnsafeN<TA, TB>(v))(a);
        }

        public static TB IfNotMapUnsafeN<TA, TB>(this TA? a, TA v, Func<TA, TB> f)
            where TA : struct
        {
            return Functions.IfNotMapUnsafeN(v, f)(a);
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

        public static bool HasNotValue<TA>(this TA? a)
            where TA : struct
        {
            return Functions.HasNotValue(a);
        }

        #endregion
    }
}
