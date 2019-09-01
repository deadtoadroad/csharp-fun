namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region Flatten

        public static Option<TA> Flatten<TA>(Option<Option<TA>> a)
        {
            return IsSome(a) ? a.GetUnsafe() : None<TA>();
        }

        #endregion
    }
}
