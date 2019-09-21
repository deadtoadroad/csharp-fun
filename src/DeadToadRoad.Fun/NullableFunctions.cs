using System;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region If

        public static Func<TA?, Option<TA>> IfN<TA>(Func<TA, bool> p)
            where TA : struct
        {
            return a => ToOption(a).Filter(p);
        }

        public static Func<TA?, Option<TA>> IfN<TA>(TA v)
            where TA : struct
        {
            return IfN(IsEqual(v));
        }

        public static Func<TA?, Option<TA>> IfNotN<TA>(TA v)
            where TA : struct
        {
            return IfN(IsNotEqual(v));
        }

        public static Func<Func<TA, TB>, Func<TA?, Option<TB>>> IfMapN<TA, TB>(Func<TA, bool> p)
            where TA : struct
        {
            return f => Compose(OptionMembers.Map(f), IfN(p));
        }

        public static Func<TA?, Option<TB>> IfMapN<TA, TB>(Func<TA, bool> p, Func<TA, TB> f)
            where TA : struct
        {
            return IfMapN<TA, TB>(p)(f);
        }

        public static Func<Func<TA, TB>, Func<TA?, Option<TB>>> IfMapN<TA, TB>(TA v)
            where TA : struct
        {
            return IfMapN<TA, TB>(IsEqual(v));
        }

        public static Func<TA?, Option<TB>> IfMapN<TA, TB>(TA v, Func<TA, TB> f)
            where TA : struct
        {
            return IfMapN<TA, TB>(v)(f);
        }

        public static Func<Func<TA, TB>, Func<TA?, Option<TB>>> IfNotMapN<TA, TB>(TA v)
            where TA : struct
        {
            return IfMapN<TA, TB>(IsNotEqual(v));
        }

        public static Func<TA?, Option<TB>> IfNotMapN<TA, TB>(TA v, Func<TA, TB> f)
            where TA : struct
        {
            return IfNotMapN<TA, TB>(v)(f);
        }

        public static Func<Func<TA, TB>, Func<TA?, TB>> IfMapUnsafeN<TA, TB>(Func<TA, bool> p)
            where TA : struct
        {
            return Compose(Compose<TA?, Option<TB>, TB>(OptionMembers.GetUnsafe), IfMapN<TA, TB>(p));
        }

        public static Func<TA?, TB> IfMapUnsafeN<TA, TB>(Func<TA, bool> p, Func<TA, TB> f)
            where TA : struct
        {
            return IfMapUnsafeN<TA, TB>(p)(f);
        }

        public static Func<Func<TA, TB>, Func<TA?, TB>> IfMapUnsafeN<TA, TB>(TA v)
            where TA : struct
        {
            return IfMapUnsafeN<TA, TB>(IsEqual(v));
        }

        public static Func<TA?, TB> IfMapUnsafeN<TA, TB>(TA v, Func<TA, TB> f)
            where TA : struct
        {
            return IfMapUnsafeN<TA, TB>(v)(f);
        }

        public static Func<Func<TA, TB>, Func<TA?, TB>> IfNotMapUnsafeN<TA, TB>(TA v)
            where TA : struct
        {
            return IfMapUnsafeN<TA, TB>(IsNotEqual(v));
        }

        public static Func<TA?, TB> IfNotMapUnsafeN<TA, TB>(TA v, Func<TA, TB> f)
            where TA : struct
        {
            return IfNotMapUnsafeN<TA, TB>(v)(f);
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

        public static bool HasNotValue<TA>(TA? a)
            where TA : struct
        {
            return Not<TA?>(NullableMembers.HasValue)(a);
        }

        #endregion
    }
}
