namespace DeadToadRoad.Fun
{
    public static class NullableMembers
    {
        #region Predicates

        public static bool HasValue<TA>(TA? a)
            where TA : struct
        {
            return a.HasValue;
        }

        #endregion
    }
}
