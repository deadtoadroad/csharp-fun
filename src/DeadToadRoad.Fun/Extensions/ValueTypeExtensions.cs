namespace DeadToadRoad.Fun.Extensions
{
    public static class ValueTypeExtensions
    {
        #region Predicates

        public static bool IsDefault<TA>(this TA a)
            where TA : struct
        {
            return ValueTypeFunctions.IsDefault(a);
        }

        public static bool IsNotDefault<TA>(this TA a)
            where TA : struct
        {
            return ValueTypeFunctions.IsNotDefault(a);
        }

        #endregion
    }
}
