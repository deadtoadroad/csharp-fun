using System;

namespace DeadToadRoad.Fun.Extensions
{
    public static class BoolExtensions
    {
        #region If

        public static Option<TB> IfMap<TB>(this bool a, TB b)
        {
            return Functions.IfMap(b)(a);
        }

        public static Option<TB> IfNotMap<TB>(this bool a, TB b)
        {
            return Functions.IfNotMap(b)(a);
        }

        public static Option<TB> IfMap<TB>(this bool a, Func<TB> f)
        {
            return Functions.IfMap(f)(a);
        }

        public static Option<TB> IfNotMap<TB>(this bool a, Func<TB> f)
        {
            return Functions.IfNotMap(f)(a);
        }

        public static TB IfMapUnsafe<TB>(this bool a, TB b)
        {
            return Functions.IfMapUnsafe(b)(a);
        }

        public static TB IfNotMapUnsafe<TB>(this bool a, TB b)
        {
            return Functions.IfNotMapUnsafe(b)(a);
        }

        public static TB IfMapUnsafe<TB>(this bool a, Func<TB> f)
        {
            return Functions.IfMapUnsafe(f)(a);
        }

        public static TB IfNotMapUnsafe<TB>(this bool a, Func<TB> f)
        {
            return Functions.IfNotMapUnsafe(f)(a);
        }

        #endregion

        #region Predicates

        public static bool IsTrue(this bool a)
        {
            return Functions.IsTrue(a);
        }

        public static bool IsFalse(this bool a)
        {
            return Functions.IsFalse(a);
        }

        #endregion
    }
}
