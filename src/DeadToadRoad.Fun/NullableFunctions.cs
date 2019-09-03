using System;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region If

        public static Func<Func<TA, TB>, Func<TA?, Option<TB>>> IfN<TA, TB>(TA v)
            where TA : struct
        {
            return f => a => AsOption(a).Filter(IsEqual(v)).Map(f);
        }

        public static Func<Func<TA, TB>, Func<TA?, Option<TB>>> IfNotN<TA, TB>(TA v)
            where TA : struct
        {
            return f => a => AsOption(a).Filter(IsNotEqual(v)).Map(f);
        }

        public static Func<Func<TA, TB>, Func<TA?, TB>> IfNUnsafe<TA, TB>(TA v)
            where TA : struct
        {
            return f => a => IfN<TA, TB>(v)(f)(a).GetUnsafe();
        }

        public static Func<Func<TA, TB>, Func<TA?, TB>> IfNotNUnsafe<TA, TB>(TA v)
            where TA : struct
        {
            return f => a => IfNotN<TA, TB>(v)(f)(a).GetUnsafe();
        }

        #endregion

        #region Map

        public static Func<Func<TB>, Func<TA?, TB>> BiMapN<TA, TB>(Func<TA, TB> f)
            where TA : struct
        {
            return @null => a => AsOption(a).Map(f).GetOrElse(@null());
        }

        public static Func<TA?, TB> MapUnsafeN<TA, TB>(Func<TA, TB> f)
            where TA : struct
        {
            return a => AsOption(a).Map(f).GetUnsafe();
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
