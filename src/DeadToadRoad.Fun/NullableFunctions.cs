using System;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region If

        public static Func<Func<TA?, TB>, Func<TA?, TB>> IfN<TA, TB>(TA? v)
            where TA : struct
        {
            return If<TA?, TB>(IsEqual(v));
        }

        public static Func<Func<TA?, TB>, Func<TA?, TB>> IfNotN<TA, TB>(TA? v)
            where TA : struct
        {
            return If<TA?, TB>(IsNotEqual(v));
        }

        #endregion

        #region Predicates

        public static bool IsNullable<TA>(TA a)
        {
            return Nullable.GetUnderlyingType(typeof(TA)) != null;
        }

        public static bool IsNotNullable<TA>(TA a)
        {
            return Not<TA>(IsNullable)(a);
        }

        public static bool HasValue<TA>(TA? a)
            where TA : struct
        {
            return a.HasValue;
        }

        public static bool HasNotValue<TA>(TA? a)
            where TA : struct
        {
            return Not<TA?>(HasValue)(a);
        }

        #endregion
    }
}
