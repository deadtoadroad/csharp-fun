namespace DeadToadRoad.Fun.Extensions
{
    public static class OptionExtensions
    {
        #region Factories

        public static Option<TA> AsOption<TA>(this TA? a)
            where TA : struct
        {
            return Functions.AsOption(a);
        }

        public static Option<TA> AsOption<TA>(this TA a)
        {
            return Functions.AsOption(a);
        }

        #endregion
    }
}
