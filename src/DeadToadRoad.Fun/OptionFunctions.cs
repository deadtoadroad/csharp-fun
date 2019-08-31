namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region Factories

        public static Some<TA> Some<TA>(TA a)
        {
            return new Some<TA>(a);
        }

        public static None<TA> None<TA>()
        {
            return Option<TA>.None;
        }

        #endregion

        #region Predicates

        public static bool IsSome<TA>(Option<TA> a)
        {
            return a is Some<TA>;
        }

        public static bool IsNone<TA>(Option<TA> a)
        {
            return a is None<TA>;
        }

        #endregion
    }
}
