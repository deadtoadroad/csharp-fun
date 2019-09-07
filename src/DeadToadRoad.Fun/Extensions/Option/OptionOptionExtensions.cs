namespace DeadToadRoad.Fun.Extensions
{
    public static class OptionOptionExtensions
    {
        #region Members

        public static Option<TA> Flatten<TA>(this Option<Option<TA>> a)
        {
            return OptionMembers.Flatten(a);
        }

        #endregion
    }
}
