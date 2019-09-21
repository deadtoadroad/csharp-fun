using System;

namespace DeadToadRoad.Fun.Extensions
{
    public static class ValueTypeExtensions
    {
        #region If

        public static Option<TA> If<TA>(this TA a, TA v)
            where TA : struct
        {
            return Functions.If(v)(a);
        }

        public static Option<TA> IfNot<TA>(this TA a, TA v)
            where TA : struct
        {
            return Functions.IfNot(v)(a);
        }

        public static Func<Func<TA, TB>, Option<TB>> IfMap<TA, TB>(this TA a, TA v)
            where TA : struct
        {
            return Functions.RotateRight2(Functions.IfMap<TA, TB>(v))(a);
        }

        public static Option<TB> IfMap<TA, TB>(this TA a, TA v, Func<TA, TB> f)
            where TA : struct
        {
            return Functions.IfMap(v, f)(a);
        }

        public static Func<Func<TA, TB>, Option<TB>> IfNotMap<TA, TB>(this TA a, TA v)
            where TA : struct
        {
            return Functions.RotateRight2(Functions.IfNotMap<TA, TB>(v))(a);
        }

        public static Option<TB> IfNotMap<TA, TB>(this TA a, TA v, Func<TA, TB> f)
            where TA : struct
        {
            return Functions.IfNotMap(v, f)(a);
        }

        public static Func<Func<TA, TB>, TB> IfMapUnsafe<TA, TB>(this TA a, TA v)
            where TA : struct
        {
            return Functions.RotateRight2(Functions.IfMapUnsafe<TA, TB>(v))(a);
        }

        public static TB IfMapUnsafe<TA, TB>(this TA a, TA v, Func<TA, TB> f)
            where TA : struct
        {
            return Functions.IfMapUnsafe(v, f)(a);
        }

        public static Func<Func<TA, TB>, TB> IfNotMapUnsafe<TA, TB>(this TA a, TA v)
            where TA : struct
        {
            return Functions.RotateRight2(Functions.IfNotMapUnsafe<TA, TB>(v))(a);
        }

        public static TB IfNotMapUnsafe<TA, TB>(this TA a, TA v, Func<TA, TB> f)
            where TA : struct
        {
            return Functions.IfNotMapUnsafe(v, f)(a);
        }

        #endregion

        #region Predicates

        public static bool IsDefault<TA>(this TA a)
            where TA : struct
        {
            return Functions.IsDefault(a);
        }

        public static bool IsNotDefault<TA>(this TA a)
            where TA : struct
        {
            return Functions.IsNotDefault(a);
        }

        #endregion
    }
}
