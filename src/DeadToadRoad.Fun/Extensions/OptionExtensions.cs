namespace DeadToadRoad.Fun.Extensions
{
    public static class OptionExtensions
    {
        #region Flatten

        public static Option<TA> Flatten<TA>(this Option<Option<TA>> a)
        {
            return Functions.Flatten(a);
        }

        #endregion

        #region Predicates

        public static bool IsSome<TA>(this Option<TA> a)
        {
            return Functions.IsSome(a);
        }

        public static bool IsNone<TA>(this Option<TA> a)
        {
            return Functions.IsNone(a);
        }

        #endregion
    }
}
