using System;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region If

        public static Func<Func<TA?, TB>, Func<TA?, Option<TB>>> If<TA, TB>(TA? v)
            where TA : struct
        {
            return If<TA?, TB>(IsEqual(v));
        }

        public static Func<Func<TA?, TB>, Func<TA?, Option<TB>>> IfNot<TA, TB>(TA? v)
            where TA : struct
        {
            return If<TA?, TB>(IsNotEqual(v));
        }

        #endregion

        #region Predicates

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
