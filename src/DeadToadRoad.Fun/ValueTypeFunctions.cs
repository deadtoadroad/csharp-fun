namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region Predicates

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
