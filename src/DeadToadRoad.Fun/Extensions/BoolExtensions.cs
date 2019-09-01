using System;

namespace DeadToadRoad.Fun.Extensions
{
    public static class BoolExtensions
    {
        #region If

        public static Option<TA> If<TA>(this bool a, Func<TA> f)
        {
            return Functions.If(f)(a);
        }

        public static Option<TA> IfNot<TA>(this bool a, Func<TA> f)
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
