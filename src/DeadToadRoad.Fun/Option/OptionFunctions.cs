namespace DeadToadRoad.Fun.Option
{
    public static class OptionFunctions
    {
        public static Some<TA> Some<TA>(TA a)
        {
            return new Some<TA>(a);
        }

        public static None<TA> None<TA>()
        {
            return Option<TA>.None;
        }
    }
}
