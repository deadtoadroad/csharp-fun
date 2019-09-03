using System;

namespace DeadToadRoad.Fun.Extensions
{
    public static class ValueTypeExtensions
    {
        #region If

        public static Func<Func<TA, TB>, Option<TB>> If<TA, TB>(this TA a, TA v)
            where TA : struct
        {
            return Functions.Rotate(Functions.If<TA, TB>(v))(a);
        }

        public static Func<Func<TA, TB>, Option<TB>> IfNot<TA, TB>(this TA a, TA v)
            where TA : struct
        {
            return Functions.Rotate(Functions.IfNot<TA, TB>(v))(a);
        }

        public static Func<Func<TA, TB>, TB> IfUnsafe<TA, TB>(this TA a, TA v)
            where TA : struct
        {
            return Functions.Rotate(Functions.IfUnsafe<TA, TB>(v))(a);
        }

        public static Func<Func<TA, TB>, TB> IfNotUnsafe<TA, TB>(this TA a, TA v)
            where TA : struct
        {
            return Functions.Rotate(Functions.IfNotUnsafe<TA, TB>(v))(a);
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
