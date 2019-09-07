namespace DeadToadRoad.Fun.Extensions
{
    public static class OptionExtensions
    {
        #region Factories

        public static Option<TA> ToOption<TA>(this TA? a)
            where TA : struct
        {
            return OptionFunctions.ToOption(a);
        }

        public static Option<TA> ToOption<TA>(this TA a)
        {
            return OptionFunctions.ToOption(a);
        }

        #endregion
    }
}
