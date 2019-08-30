using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun
{
    public static class ValueTypeFunctions
    {
        #region Predicates

        public static bool IsDefault<TA>(TA a)
            where TA : struct
        {
            return ObjectFunctions.IsEqual(default(TA))(a);
        }

        public static bool IsNotDefault<TA>(TA a)
            where TA : struct
        {
            return Not<TA>(IsDefault)(a);
        }

        #endregion
    }
}
