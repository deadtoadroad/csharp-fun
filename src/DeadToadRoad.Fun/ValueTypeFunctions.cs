using System;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region If

        public static Func<TA, Option<TA>> If<TA>(TA v)
            where TA : struct
        {
            return If(IsEqual(v));
        }

        public static Func<TA, Option<TA>> IfNot<TA>(TA v)
            where TA : struct
        {
            return If(IsNotEqual(v));
        }

        public static Func<Func<TA, TB>, Func<TA, Option<TB>>> IfMap<TA, TB>(TA v)
            where TA : struct
        {
            return IfMap<TA, TB>(IsEqual(v));
        }

        public static Func<TA, Option<TB>> IfMap<TA, TB>(TA v, Func<TA, TB> f)
            where TA : struct
        {
            return IfMap<TA, TB>(v)(f);
        }

        public static Func<Func<TA, TB>, Func<TA, Option<TB>>> IfNotMap<TA, TB>(TA v)
            where TA : struct
        {
            return IfMap<TA, TB>(IsNotEqual(v));
        }

        public static Func<TA, Option<TB>> IfNotMap<TA, TB>(TA v, Func<TA, TB> f)
            where TA : struct
        {
            return IfNotMap<TA, TB>(v)(f);
        }

        public static Func<Func<TA, TB>, Func<TA, TB>> IfMapUnsafe<TA, TB>(TA v)
            where TA : struct
        {
            return IfMapUnsafe<TA, TB>(IsEqual(v));
        }

        public static Func<TA, TB> IfMapUnsafe<TA, TB>(TA v, Func<TA, TB> f)
            where TA : struct
        {
            return IfMapUnsafe<TA, TB>(v)(f);
        }

        public static Func<Func<TA, TB>, Func<TA, TB>> IfNotMapUnsafe<TA, TB>(TA v)
            where TA : struct
        {
            return IfMapUnsafe<TA, TB>(IsNotEqual(v));
        }

        public static Func<TA, TB> IfNotMapUnsafe<TA, TB>(TA v, Func<TA, TB> f)
            where TA : struct
        {
            return IfNotMapUnsafe<TA, TB>(v)(f);
        }

        #endregion

        #region Predicates

        public static bool IsDefault<TA>(TA a)
            where TA : struct
        {
            return IsEqual(default(TA))(a);
        }

        public static bool IsNotDefault<TA>(TA a)
            where TA : struct
        {
            return Not<TA>(IsDefault)(a);
        }

        #endregion
    }
}
