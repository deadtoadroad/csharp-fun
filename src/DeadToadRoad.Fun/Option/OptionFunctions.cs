namespace DeadToadRoad.Fun
{
    public static class OptionFunctions
    {
        #region Factories

        public static Option<TA> Some<TA>(TA a)
        {
            return new Some<TA>(a);
        }

        public static Option<TA> None<TA>()
        {
            return Option<TA>.None;
        }

        public static Option<TA> ToOption<TA>(TA? a)
            where TA : struct
        {
            return Functions.If<TA?, TA>(Functions.HasValue)(NullableMembers.Value)(a);
        }

        public static Option<TA> ToOption<TA>(TA a)
        {
            return Functions.If<TA, TA>(Functions.IsNotNull)(Functions.Identity)(a);
        }

        #endregion
    }
}
