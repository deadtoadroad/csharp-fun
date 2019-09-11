namespace DeadToadRoad.Fun.Extensions
{
    public static class OptionExtensions
    {
        #region Factories

        public static Option<TA> ToOption<TA>(this TA? a)
            where TA : struct
        {
            return Functions.ToOption(a);
        }

        public static Option<TA> ToOption<TA>(this TA a)
        {
            return Functions.ToOption(a);
        }

        #endregion
    }
}
