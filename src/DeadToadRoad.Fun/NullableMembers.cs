namespace DeadToadRoad.Fun
{
    public static class NullableMembers
    {
        public static bool HasValue<TA>(TA? a)
            where TA : struct
        {
            return a.HasValue;
        }

        public static TA Value<TA>(TA? a)
            where TA : struct
        {
            // ReSharper disable once PossibleInvalidOperationException
            return a.Value;
        }
    }
}
