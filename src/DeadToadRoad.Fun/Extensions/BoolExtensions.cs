using System;

namespace DeadToadRoad.Fun.Extensions
{
    public static class BoolExtensions
    {
        #region If

        public static Option<TB> If<TB>(this bool a, TB b)
        {
            return Functions.If(b)(a);
        }

        public static Option<TB> IfNot<TB>(this bool a, TB b)
        {
            return Functions.IfNot(b)(a);
        }

        public static Option<TB> If<TB>(this bool a, Func<TB> f)
        {
            return Functions.If(f)(a);
        }

        public static Option<TB> IfNot<TB>(this bool a, Func<TB> f)
        {
            return Functions.IfNot(f)(a);
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
