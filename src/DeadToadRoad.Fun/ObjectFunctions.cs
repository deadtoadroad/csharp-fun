using System;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun
{
    public static class ObjectFunctions
    {
        #region Delay

        public static Func<TA> Delay<TA>(TA a)
        {
            return () => a;
        }

        #endregion

        #region Identity

        public static TA Identity<TA>(TA a)
        {
            return a;
        }

        #endregion

        #region Predicates

        public static Func<TA, bool> Is<TA>(Func<TA, bool> p)
        {
            return p;
        }

        public static Func<TA, bool> IsNot<TA>(Func<TA, bool> p)
        {
            return Not(p);
        }

        public static bool IsNull<TA>(TA a)
        {
            return a == null;
        }

        public static bool IsNotNull<TA>(TA a)
        {
            return Not<TA>(IsNull)(a);
        }

        #endregion
    }
}
