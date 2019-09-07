namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region Factories

        public static Option<TA> AsOption<TA>(TA? a)
            where TA : struct
        {
            // ReSharper disable once PossibleInvalidOperationException
            return If<TA?, TA>(NullableMembers.HasValue)(a1 => a1.Value)(a);
        }

        public static Option<TA> AsOption<TA>(TA a)
        {
            return If<TA, TA>(IsNotNull)(Identity)(a);
        }

        public static Option<TA> Some<TA>(TA a)
        {
            return new Some<TA>(a);
        }

        public static Option<TA> None<TA>()
        {
            return Option<TA>.None;
        }

        #endregion
    }
}
