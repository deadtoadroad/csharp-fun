using System;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region If

        public static Func<bool, Option<TB>> IfMap<TB>(TB b)
        {
            return IfMap<bool, TB>(IsTrue, _ => b);
        }

        public static Func<bool, Option<TB>> IfNotMap<TB>(TB b)
        {
            return IfMap<bool, TB>(IsFalse, _ => b);
        }

        public static Func<bool, Option<TB>> IfMap<TB>(Func<TB> f)
        {
            return IfMap<bool, TB>(IsTrue, _ => f());
        }

        public static Func<bool, Option<TB>> IfNotMap<TB>(Func<TB> f)
        {
            return IfMap<bool, TB>(IsFalse)(_ => f());
        }

        public static Func<bool, TB> IfMapUnsafe<TB>(TB b)
        {
            return IfMapUnsafe<bool, TB>(IsTrue, _ => b);
        }

        public static Func<bool, TB> IfNotMapUnsafe<TB>(TB b)
        {
            return IfMapUnsafe<bool, TB>(IsFalse, _ => b);
        }

        public static Func<bool, TB> IfMapUnsafe<TB>(Func<TB> f)
        {
            return IfMapUnsafe<bool, TB>(IsTrue, _ => f());
        }

        public static Func<bool, TB> IfNotMapUnsafe<TB>(Func<TB> f)
        {
            return IfMapUnsafe<bool, TB>(IsFalse, _ => f());
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
