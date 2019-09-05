using System;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region If

        public static Func<Func<TA?, TB>, Func<TA?, Option<TB>>> IfN<TA, TB>(TA? v)
            where TA : struct
        {
            return If<TA?, TB>(IsEqual(v));
        }

        public static Func<Func<TA?, TB>, Func<TA?, Option<TB>>> IfNotN<TA, TB>(TA? v)
            where TA : struct
        {
            return If<TA?, TB>(IsNotEqual(v));
        }

        public static Func<Func<TA?, TB>, Func<TA?, TB>> IfNUnsafe<TA, TB>(TA? v)
            where TA : struct
        {
            return f => Flow2<TA?, Option<TB>, TB>(IfN<TA, TB>(v)(f))(OptionMembers.GetUnsafe);
        }

        public static Func<Func<TA?, TB>, Func<TA?, TB>> IfNotNUnsafe<TA, TB>(TA? v)
            where TA : struct
        {
            return f => Flow2<TA?, Option<TB>, TB>(IfNotN<TA, TB>(v)(f))(OptionMembers.GetUnsafe);
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
