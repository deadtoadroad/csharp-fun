namespace DeadToadRoad.Fun.Extensions
{
    public static class ValueTypeExtensions
    {
        #region Predicates

        public static bool IsDefault<TA>(this TA a)
            where TA : struct
        {
            return Functions.IsDefault(a);
        }

        public static bool IsNotDefault<TA>(this TA a)
            where TA : struct
        {
            return Functions.IsNotDefault(a);
        }

        #endregion
    }
}
