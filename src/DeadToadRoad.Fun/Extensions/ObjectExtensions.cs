using System;

namespace DeadToadRoad.Fun.Extensions
{
    public static class ObjectExtensions
    {
        #region Delay

        public static Func<TA> Delay<TA>(this TA a)
        {
            return ObjectFunctions.Delay(a);
        }

        #endregion

        #region Identity

        public static TA Identity<TA>(this TA a)
        {
            return ObjectFunctions.Identity(a);
        }

        #endregion

        #region Predicates

        public static bool Is<TA>(this TA a, Func<TA, bool> p)
        {
            return ObjectFunctions.Is(p)(a);
        }

        public static bool IsNot<TA>(this TA a, Func<TA, bool> p)
        {
            return ObjectFunctions.IsNot(p)(a);
        }

        public static bool IsEqual<TA>(this TA a, TA v)
            where TA : struct
        {
            return ObjectFunctions.IsEqual(v)(a);
        }

        public static bool IsNotEqual<TA>(this TA a, TA v)
            where TA : struct
        {
            return ObjectFunctions.IsNotEqual(v)(a);
        }

        public static bool IsNull<TA>(this TA a)
        {
            return ObjectFunctions.IsNull(a);
        }

        public static bool IsNotNull<TA>(this TA a)
        {
            return ObjectFunctions.IsNotNull(a);
        }

        #endregion
    }
}
