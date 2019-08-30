using System;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun
{
    public static class ValueTypeFunctions
    {
        #region Predicates

        public static Func<TA, bool> IsEqual<TA>(TA v)
            where TA : struct
        {
            return a => a.Equals(v);
        }

        public static Func<TA, bool> IsNotEqual<TA>(TA v)
            where TA : struct
        {
            return Not(IsEqual(v));
        }

        public static bool IsDefault<TA>(TA a)
            where TA : struct
        {
            return IsEqual(default(TA))(a);
        }

        public static bool IsNotDefault<TA>(TA a)
            where TA : struct
        {
            return Not<TA>(IsDefault)(a);
        }

        #endregion
    }
}
