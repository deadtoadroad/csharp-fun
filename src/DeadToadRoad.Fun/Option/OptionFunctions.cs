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
            return NullableMembers.HasValue(a) ? Some(NullableMembers.Value(a)) : None<TA>();
        }

        public static Option<TA> ToOption<TA>(TA a)
        {
            return IsNotNull(a) ? Some(a) : None<TA>();
        }

        #endregion
    }
}
