using System;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region If

        public static Func<Func<TA, TB>, Func<TA, Option<TB>>> If<TA, TB>(TA v)
            where TA : struct
        {
            return If<TA, TB>(IsEqual(v));
        }

        public static Func<Func<TA, TB>, Func<TA, Option<TB>>> IfNot<TA, TB>(TA v)
            where TA : struct
        {
            return If<TA, TB>(IsNotEqual(v));
        }

        public static Func<Func<TA, TB>, Func<TA, TB>> IfUnsafe<TA, TB>(TA v)
            where TA : struct
        {
            return f => a => If<TA, TB>(v)(f)(a).GetUnsafe();
        }

        public static Func<Func<TA, TB>, Func<TA, TB>> IfNotUnsafe<TA, TB>(TA v)
            where TA : struct
        {
            return f => a => IfNot<TA, TB>(v)(f)(a).GetUnsafe();
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
