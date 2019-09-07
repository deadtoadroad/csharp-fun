namespace DeadToadRoad.Fun
{
    public static class NullableMembers
    {
        public static TA Value<TA>(TA? a)
            where TA : struct
        {
            // ReSharper disable once PossibleInvalidOperationException
            return a.Value;
        }
    }
}
