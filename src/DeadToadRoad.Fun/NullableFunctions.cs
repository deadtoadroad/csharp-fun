using System;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region If

        public static Func<Func<TA, TB>, Func<TA?, Option<TB>>> IfN<TA, TB>(TA v)
            where TA : struct
        {
            // ReSharper disable once PossibleInvalidOperationException
            return f => If<TA?, TB>(IsEqual<TA?>(v))(a => f(a.Value));
        }

        public static Func<Func<TA?, TB>, Func<TA?, Option<TB>>> IfNotN<TA, TB>(TA v)
            where TA : struct
        {
            return If<TA?, TB>(IsNotEqual<TA?>(v));
        }

        #endregion

        #region Map

        public static Func<Func<TB>, Func<TA?, TB>> BiMapN<TA, TB>(Func<TA, TB> f)
            where TA : struct
        {
            // ReSharper disable once PossibleInvalidOperationException
            return BiMap<TA?, TB>(a => f(a.Value));
        }

        public static Func<TA?, TB> MapUnsafeN<TA, TB>(Func<TA, TB> f)
            where TA : struct
        {
            // ReSharper disable once PossibleInvalidOperationException
            return MapUnsafe<TA?, TB>(a => f(a.Value));
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
