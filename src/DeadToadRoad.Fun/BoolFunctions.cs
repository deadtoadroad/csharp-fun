using System;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region If

        public static Func<bool, Option<TA>> If<TA>(Func<TA> f)
        {
            return If<bool, TA>(IsTrue)(_ => f());
        }

        public static Func<bool, Option<TA>> IfNot<TA>(Func<TA> f)
        {
            return If<bool, TA>(IsFalse)(_ => f());
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
