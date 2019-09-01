namespace DeadToadRoad.Fun.Extensions
{
    public static class OptionOptionExtensions
    {
        #region Flatten

        public static Option<TA> Flatten<TA>(this Option<Option<TA>> a)
        {
            return Functions.Flatten(a);
        }

        #endregion
    }
}
