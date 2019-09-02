using System;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region If

        public static Func<bool, Option<TB>> If<TB>(TB b)
        {
            return If(() => b);
        }

        public static Func<bool, Option<TB>> IfNot<TB>(TB b)
        {
            return IfNot(() => b);
        }

        public static Func<bool, Option<TB>> If<TB>(Func<TB> f)
        {
            return If<bool, TB>(IsTrue)(_ => f());
        }

        public static Func<bool, Option<TB>> IfNot<TB>(Func<TB> f)
        {
            return If<bool, TB>(IsFalse)(_ => f());
        }

        #endregion

        #region Predicates

        public static bool IsTrue(bool a)
        {
            return a;
        }

        public static bool IsFalse(bool a)
        {
            return Not<bool>(IsTrue)(a);
        }

        #endregion
    }
}
