namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region Factories

        public static Option<TA> AsOption<TA>(TA? a)
            where TA : struct
        {
            // ReSharper disable once PossibleInvalidOperationException
            return IsNotNull(a) ? Some(a.Value) : None<TA>();
        }

        public static Option<TA> AsOption<TA>(TA a)
        {
            return IsNotNull(a) ? Some(a) : None<TA>();
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
