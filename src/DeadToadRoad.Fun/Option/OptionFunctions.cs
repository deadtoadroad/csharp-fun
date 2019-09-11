namespace DeadToadRoad.Fun
{
    public static partial class Functions
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
            return If<TA?, TA>(HasValue)(NullableMembers.Value)(a);
        }

        public static Option<TA> ToOption<TA>(TA a)
        {
            return If<TA, TA>(IsNotNull)(Identity)(a);
        }

        #endregion
    }
}
